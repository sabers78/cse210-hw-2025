public class Resume
{
    public string name = "Bob Marley";

    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine(name);
        Console.WriteLine("Jobs:");

        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }


}