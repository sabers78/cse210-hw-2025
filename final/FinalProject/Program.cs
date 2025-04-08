using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int totalNumberOfHousesInstalled = 0;

        
        Christmas firstInstall = new Christmas(0, 3, 1.12f, 0.5f, 1, 2025);
        Christmas reinstall = new Christmas(0, 3, 1.12f, 0.5f, 2, 2025);
        Govee govee = new Govee(0, 4, 0.4f, 1); // sample values
        Landscape landscape = new Landscape(0, 2, 1.25f, 0.6f);
        Permanent permanentLight = new Permanent(0, 5, 1.5f, 0.7f);

        
        int newCustomer = 0;
        int reinstallCustomer = 0;
        int goveeCount = 0;
        int landscapeCount = 0;
        int permLightCount = 0;

        Random rand = new Random();

        for (int i = 0; i < 1000; i++)
        {
            totalNumberOfHousesInstalled++;
            double probability = rand.NextDouble();

            if (probability <= 0.60) // 60% chance for Christmas
            {
                newCustomer++;

                if (newCustomer >= 3)
                {
                    reinstallCustomer++;
                    newCustomer = 0;
                }

                Console.WriteLine($"House {totalNumberOfHousesInstalled}: Christmas house installed.");
            }
            else if (probability <= 0.70)
            {
                goveeCount++;
                Console.WriteLine($"House {totalNumberOfHousesInstalled}: Govee house installed.");
            }
            else if (probability <= 0.80)
            {
                landscapeCount++;
                Console.WriteLine($"House {totalNumberOfHousesInstalled}: Landscape house installed.");
            }
            else
            {
                permLightCount++;
                Console.WriteLine($"House {totalNumberOfHousesInstalled}: PermanentLight house installed.");
            }
        }

        
        firstInstall.SetTotalNumberOfHousesInstalled(newCustomer);
        reinstall.SetTotalNumberOfHousesInstalled(reinstallCustomer);
        govee.SetTotalNumberOfHousesInstalled(goveeCount);
        landscape.SetTotalNumberOfHousesInstalled(landscapeCount);
        permanentLight.SetTotalNumberOfHousesInstalled(permLightCount);

        
        List<Service> services = new List<Service>
        {
            firstInstall,
            reinstall,
            govee,
            landscape,
            permanentLight
        };

        
        string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        string csvPath = Path.Combine(projectDirectory, "service_stats.csv");

    
        using (StreamWriter writer = new StreamWriter(csvPath))
        {
            writer.WriteLine("Service,5-Day Wage,Gross Income,Profit,Price Per Foot");

            double totalGrossIncome = 0;
            double totalProfit = 0;

            foreach (Service service in services)
            {
                float fiveDayWage = service.EmployeeCostPerJob() * 5;
                double grossIncome = service.CalculateServiceGrossincome();
                double profit = service.CalculateProfit();
                double pricePerFoot = service.pricePerFoot();

                totalGrossIncome += grossIncome;
                totalProfit += profit;

                writer.WriteLine($"{service.GetType().Name},{fiveDayWage:F2},{grossIncome:F2},{profit:F2},{pricePerFoot:F2}");
            }

            writer.WriteLine();
            writer.WriteLine($",Total Gross Income:,{totalGrossIncome:F2}");
            writer.WriteLine($",Total Profit:,,{totalProfit:F2}");
        }

        Console.WriteLine($"Stats written to {csvPath}");
        Console.WriteLine("Total number of houses installed: " + totalNumberOfHousesInstalled);
    }
}
