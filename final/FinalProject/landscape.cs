public class Landscape : Service
{
  

    public Landscape(int totalNumberOfHousesInstalled, int employeesPerJob, float materialCostPerFoot, float wagePerFoot)
        : base(totalNumberOfHousesInstalled, 1f, employeesPerJob, materialCostPerFoot, wagePerFoot)
    {
        
       
    }

    public override float GetWagePerFoot()
    {
        return 3f; 
    }

    public override float GetMaterialCostPerFoot()
    {
        return 22f; 
    }

    public override int GetEmployeesPerJob()
    {
        return 3;
    }

}
