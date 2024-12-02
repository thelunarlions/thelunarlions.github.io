using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class DataPoint
{
    public double Time { get; set; }
    public double Rx { get; set; }
    public double Ry { get; set; }
    public double Rz { get; set; }
    public double Vx { get; set; }
    public double Vy { get; set; }
    public double Vz { get; set; }
    public double M { get; set; }
    public double Wpsa { get; set; }
    public double? WpsaBudget { get; set; }
    public double Ds54 { get; set; }
    public string Ds54Budget { get; set; }
    public double Ds24 { get; set; }
    public string Ds24Budget { get; set; }
    public double Ds34 { get; set; }
    public string Ds34Budget { get; set; }
}


class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\Tony\\Desktop\\Unity thing\\Unity thing\\data.json";

        try
        {
            // Read the JSON file content
            string jsonData = File.ReadAllText(filePath);

            // Deserialize JSON array into a list of DataPoint objects
            List<DataPoint> dataPoints = JsonConvert.DeserializeObject<List<DataPoint>>(jsonData);

            // Access and print each data point
            foreach (var dataPoint in dataPoints)
            {
                Console.WriteLine($"Time: {dataPoint.Time}, Rx: {dataPoint.Rx}, Ry: {dataPoint.Ry}, Rz: {dataPoint.Rz}");
                Console.WriteLine($"Velocity: Vx={dataPoint.Vx}, Vy={dataPoint.Vy}, Vz={dataPoint.Vz}");
                Console.WriteLine($"Mass: {dataPoint.M}, WPSA: {dataPoint.Wpsa}, WPSA Budget: {dataPoint.WpsaBudget}");
                Console.WriteLine($"DS54: {dataPoint.Ds54}, DS54 Budget: {dataPoint.Ds54Budget}");
                Console.WriteLine($"DS24: {dataPoint.Ds24}, DS24 Budget: {dataPoint.Ds24Budget}");
                Console.WriteLine($"DS34: {dataPoint.Ds34}, DS34 Budget: {dataPoint.Ds34Budget}");
                Console.WriteLine(new string('-', 50));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
