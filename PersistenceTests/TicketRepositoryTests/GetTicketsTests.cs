using Domain.Entities;
using GenFu;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceTests.TicketRepositoryTests
{
    public class GetTicketsTests
    {
        public readonly DbContextOptions<ParkerDbContext> dbContextOptions;

        public GetTicketsTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<ParkerDbContext>()
                .UseInMemoryDatabase(databaseName: "MyBlogDb")
                .Options;
        }

        [Fact]
        public async Task GetTickets_ThereAreTicketsSaved_ReturnListTickets()
        {
            var parkerContext = new ParkerDbContext(dbContextOptions);

            TicketRepository repository = new(parkerContext);

            var newTickets = A.ListOf<Ticket>(10);

            parkerContext.AddRange(newTickets);
            parkerContext.SaveChanges();

            // Act
            var tickets = await repository.GetTickets();

            // Assert
            Assert.NotEmpty(tickets);
            Assert.Equal(10, tickets.Count!);
        }

        [Fact]
        public async Task GetTickets_ThereAreNotTickets_ReturnEmpty()
        {
            var parkerContext = new ParkerDbContext(dbContextOptions);
            TicketRepository repository = new(parkerContext);

            // Act
            var tickets = await repository.GetTickets();

            // Assert
            Assert.Equal(10, tickets.Count!);
        }

        [Fact]
        public async Task GetTickets_DbContextIsNull_ThrowNullReferenceException()
        {
            TicketRepository repository = new(null!);

            // Act

            // Assert
            await Assert.ThrowsAsync<NullReferenceException>(() => repository.GetTickets());
        }
    }
}
