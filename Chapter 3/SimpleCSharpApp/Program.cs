// Local method within the Top-level statements.
ShowEnvironmentDetails();
Console.ReadLine();
return -1;

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}", Environment.Version);
}
