using System;
public abstract class Service : Overhead
{
   
    private float _housesInstalledPerService;
    private int _averageFootage = 100; // Default average footage per house
    private int _employeesPerJob;
    private float _materialCostPerFoot; 
    private float _preferedProfitRate = 0.4f; 
    private float _wagePerFoot; 

 
    public Service(int totalNumberOfHousesInstalled, float housesInstalledPerService, int employeesPerJob, float materialCostPerFoot, float wagePerFoot) : base(totalNumberOfHousesInstalled)
    {
        _housesInstalledPerService = housesInstalledPerService;
        _employeesPerJob = employeesPerJob;
        _materialCostPerFoot = materialCostPerFoot; 
        _wagePerFoot = wagePerFoot;

        
        
    }


    public float MaterialCostPerJob() 
    {
        
        float totalMaterialCost =  GetAverageFootage() * GetMaterialCostPerFoot();
        return totalMaterialCost;
    }

    // Calculates the total employee wage cost for one job
    public float EmployeeCostPerJob() 
    {
        //wage per foot for the day
        float totalEmployeeCost = GetWagePerFoot() * GetAverageFootage();

        return totalEmployeeCost;
    }

    

    public float MarketingCostPerFoot()
    {
        return 0.10f;
    }


    public abstract float GetWagePerFoot();
    

    public virtual int GetEmployeesPerJob()
    {
        return _employeesPerJob;
    }

     public int GetAverageFootage()
    {
        return _averageFootage;
    }

     public abstract float GetMaterialCostPerFoot();
    

    public virtual double JobExpensesPerFoot()
    {
        double cost = ((GetMaterialCostPerFoot() * GetAverageFootage()) + (GetEmployeesPerJob() * GetWagePerFoot() * GetAverageFootage()) + (OverheadCost() / GetAverageFootage()) + (MarketingCostPerFoot() * GetAverageFootage())) / GetAverageFootage();
        return cost;
    }
    public double pricePerFoot()
    {
        double actualCost = JobExpensesPerFoot() + _preferedProfitRate;
        
        return actualCost;
    }
    
    public double CalculateServiceGrossincome()
    {
        double serviceGrossIncome = _housesInstalledPerService * GetAverageFootage();
        return serviceGrossIncome * pricePerFoot();//I want the program to help me decide how much to charge customers, although that may not be done in this method
    }

    public double CalculateProfit()
    {
        
        return CalculateServiceGrossincome() * _preferedProfitRate;
    }

    

     

}