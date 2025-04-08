public class Overhead 
{
    protected int _totalNumberOfHousesInstalled;
    private double _rateOfRepairs = 0.01; //This is the percentages of the total number of houses that need repairs

    public Overhead(int totalNumberOfHousesInstalled)
    {
        _totalNumberOfHousesInstalled = totalNumberOfHousesInstalled;
    }
    public double RepairRateCost()// I am trying to see how much repairs cost
    {
        float numberOfRepairs = _totalNumberOfHousesInstalled * (float)_rateOfRepairs;
        double repairCost = numberOfRepairs * 100; //This says that it costs 100 dollars for each repair. (This is data I can't know unles i were to acutally run a business, and thus i am just guessing.)
        return repairCost;
    }

    public int TotalNumberOfEmployees()
    {
        int employees = _totalNumberOfHousesInstalled / 60;// For every 60 jobs, i need one employee.
        return employees;
    }

    public double OverheadCost()
    {
        double gas = 14 * _totalNumberOfHousesInstalled;
        int software = 4332; // the amount in a year that different software costs
        int tools = 1500 * TotalNumberOfEmployees();  //For every employee, i have to spend 1500 dollars
        int cars = TotalNumberOfEmployees() * 350;

        return gas + software + tools + cars;


    }
    // I am not sure about this code.................................................................................
    public void SetTotalNumberOfHousesInstalled(int total)
    {
        _totalNumberOfHousesInstalled = total;
    }

    
}