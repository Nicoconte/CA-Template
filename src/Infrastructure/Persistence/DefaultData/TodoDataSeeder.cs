using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.DefaultData
{
    public static class TodoDataSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var todos = new List<TodoItem>()
            {
                new()
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Borrar este elemento",
                    IsCompleted = false
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Borrar este elemento 2",
                    IsCompleted = false
                }
            };

            builder.Entity<TodoItem>().HasData(todos);
        }
    }
}
