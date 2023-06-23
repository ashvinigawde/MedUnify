using MedUnify.WebApi.Data.Entities;

namespace MedUnify.WebApi.Data
{
    public static class DataSeeding
    {
        public static void SeedInitialData(this MedUnifyDbContext context)
        {
            SeedOrganization(context);
            SeedPatients(context);
        }
        public static void SeedOrganization(this MedUnifyDbContext context)
        {
            if (!context.Organizations.Any())
            {
                var org = new Organization
                {
                    CreatedAt = DateTime.Now,
                    Name = "City Hospital"
                };
                context.Add(org);
                context.SaveChanges();
            }
        }
        public static void SeedPatients(this MedUnifyDbContext context)
        {
            if (!context.Patients.Any())
            {
                var patients = new List<Patient>()
                    {
                        new Patient
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Address = "123 Main St",
                            State = "California",
                            City = "Los Angeles",
                            OrganizationId = 1,
                            CreatedAt = DateTime.Now
                        },
                        new Patient
                        {
                            FirstName = "Kohn",
                            LastName = "Moe",
                            Address = "123 Main St",
                            State = "California",
                            City = "Los Angeles",
                            OrganizationId = 1,
                            CreatedAt = DateTime.Now
                        },
                    };
                context.AddRange(patients);
                context.SaveChanges();

            }
        }

    }
}
