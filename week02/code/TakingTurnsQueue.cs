/// <summary>
/// This queue is circular.  When people are added via add_person, then they are added to the 
/// back of the queue (per FIFO rules).  When get_next_person is called, the next person
/// in the queue is displayed and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>
public class TakingTurnsQueue {
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    public void AddPerson(string name, int turns) {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public void GetNextPerson() {
        if (_people.IsEmpty()) {
            Console.WriteLine("No one in the queue.");
            return;
        }
        
        Person person = _people.Dequeue();
        Console.WriteLine(person.Name); // Outputs the person's name for tracking purposes

        // Decrement the turn count only if they have more than 0 turns
        if (person.Turns > 0) {
            person.Turns -= 1;
        }

        // Re-enqueue the person only if they still have turns left
        if (person.Turns > 0) {
            _people.Enqueue(person);
        }
    }

    public override string ToString() {
        return _people.ToString();
    }
}
