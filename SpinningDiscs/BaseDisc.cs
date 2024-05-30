namespace SpinningDiscs;

public abstract class BaseDisc
{
//Fields
public double Spin { get; set; }
public Dictionary<string, string> Data { get; set; } //Add a list
public string DataReading { get; set; }
//Constructor
public BaseDisc(double spin, Dictionary<string, string> data, string dataReading)
{
Spin = spin;
Data = data;
DataReading = dataReading;
}

//Methods




}