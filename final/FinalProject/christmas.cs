public class Christmas : Service
{
    private int _year; // Year of installation
    private int _currentYear; // To track the current year
    private int _totalNumberOfHousesInstalled; // Tracks the total number of houses installed (new and reinstall)

    public Christmas(int totalNumberOfHousesInstalled, int employeesPerJob, float materialCostPerFoot, float wagePerFoot, int year, int currentYear)
        : base(totalNumberOfHousesInstalled, 3f, employeesPerJob, materialCostPerFoot, wagePerFoot)
    {
        _year = year;
        _currentYear = currentYear;
        _totalNumberOfHousesInstalled = totalNumberOfHousesInstalled;
    }

    public int GetYear()
    {
        return _year;
    }

    public int GetCurrentYear()
    {
        return _currentYear;
    }

    public void SetTotalNumberOfHousesInstalled(int count)
    {
        _totalNumberOfHousesInstalled += count;
    }

    public int GetTotalNumberOfHousesInstalled()
    {
        return _totalNumberOfHousesInstalled;
    }

    public override float GetWagePerFoot()
    {
        return 0.5f; // Specific wage for Christmas installations
    }

    public override float GetMaterialCostPerFoot()
    {
        return 1.12f; // The material cost per foot for Christmas installations
    }

    public override double JobExpensesPerFoot()
    {
        // Adjust the expenses based on whether it's the first year or a reinstallation
        if (_year == 1) // First-time install
        {
            double cost = ((GetMaterialCostPerFoot() * GetAverageFootage()) + (GetEmployeesPerJob() * GetWagePerFoot() * GetAverageFootage()) + (OverheadCost() / GetAverageFootage()) + (MarketingCostPerFoot() * GetAverageFootage())) / GetAverageFootage();
            return cost;
        }
        else // Reinstallation
        {
            double cost = (((GetMaterialCostPerFoot() - 40) * GetAverageFootage()) + (GetEmployeesPerJob() * GetWagePerFoot() * GetAverageFootage()) + (OverheadCost() / GetAverageFootage()) + (MarketingCostPerFoot() * GetAverageFootage())) / GetAverageFootage();
            return cost;
        }
    }
}
