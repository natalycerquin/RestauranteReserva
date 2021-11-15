using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using Reservas.Models;
using Reservas.Models.Map;

namespace PruebasUnitarias
{
    public class ApplicationMockContext
    {
        public static Mock<ReservasDbContext> GetAplicationContextMockUser()
        {
            var data = new List<Usuario>
            {
                new Usuario { Id = 1, Password = "Admin1", Username = "Admin1" },
                new Usuario { Id = 2, Password = "Admin2", Username = "Admin2" },
                new Usuario { Id = 3, Password = "Admin3", Username = "Admin3" },
            }.AsQueryable();

            var mokSet = new Mock<DbSet<Usuario>>();
            mokSet.As<IQueryable<Usuario>>().Setup(m => m.Provider).Returns(data.Provider);
            mokSet.As<IQueryable<Usuario>>().Setup(m => m.Expression).Returns(data.Expression);
            mokSet.As<IQueryable<Usuario>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mokSet.As<IQueryable<Usuario>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var context = new Mock<ReservasDbContext>(new DbContextOptions<ReservasDbContext>());
            context.Setup(a => a.Usuarios).Returns(mokSet.Object);

            return context;
        }
    }
}
