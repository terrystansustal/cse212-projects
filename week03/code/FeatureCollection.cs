using System.Collections.Generic;
using System.Text.Json.Serialization;

public class FeatureCollection {
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature {
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }

    [JsonPropertyName("geometry")]
    public Geometry Geometry { get; set; }
}

public class Properties {
    [JsonPropertyName("mag")]
    public double Magnitude { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("time")]
    public long Time { get; set; }

    [JsonPropertyName("updated")]
    public long Updated { get; set; }

    [JsonPropertyName("tz")]
    public int? TimeZone { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("detail")]
    public string Detail { get; set; }

    [JsonPropertyName("felt")]
    public int? Felt { get; set; }

    [JsonPropertyName("cdi")]
    public double? Cdi { get; set; }

    [JsonPropertyName("mmi")]
    public double? Mmi { get; set; }

    [JsonPropertyName("alert")]
    public string Alert { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tsunami")]
    public int Tsunami { get; set; }

    [JsonPropertyName("sig")]
    public int Sig { get; set; }

    [JsonPropertyName("net")]
    public string Net { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("ids")]
    public string Ids { get; set; }

    [JsonPropertyName("sources")]
    public string Sources { get; set; }

    [JsonPropertyName("types")]
    public string Types { get; set; }

    [JsonPropertyName("nst")]
    public int? Nst { get; set; }

    [JsonPropertyName("dmin")]
    public double? Dmin { get; set; }

    [JsonPropertyName("rms")]
    public double Rms { get; set; }

    [JsonPropertyName("gap")]
    public double? Gap { get; set; }

    [JsonPropertyName("magType")]
    public string MagType { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public class Geometry {
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<double> Coordinates { get; set; }
}
