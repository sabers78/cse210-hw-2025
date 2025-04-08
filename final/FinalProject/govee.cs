public class Govee : Service
{
  

    public Govee(int totalNumberOfHousesInstalled, int employeesPerJob, float materialCostPerFoot, float wagePerFoot)
        : base(totalNumberOfHousesInstalled, 1f, employeesPerJob, materialCostPerFoot, wagePerFoot)
    {
        
       
    }

    public override float GetWagePerFoot()
    {
        return 3f; 
    }

    public override float GetMaterialCostPerFoot()
    {
        return 3.5f; 
    }

    public override int GetEmployeesPerJob()
    {
        return 2;
    }

}
