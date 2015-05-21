// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="">
//   
// </copyright>
// <summary>
//   The unit test 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UnitTests
{
    using System.Collections.Generic;
    using System.Linq;

    using @by.grsu.mf.dzianishchyk.spacestation.model;
    using @by.grsu.mf.dzianishchyk.spacestation.model.Context;
    using @by.grsu.mf.dzianishchyk.spacestation.model.IRepository;
    using @by.grsu.mf.dzianishchyk.spacestation.model.Repository;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The station name.
        /// </summary>
        private const string StationName = "Space station ONE";

        /// <summary>
        /// The station location.
        /// </summary>
        private const string StationLocation = "Tatuin, Long long galaxy far from a way";

        /// <summary>
        /// The add entity.
        /// </summary>
        [TestMethod]
        public void AddEntity()
        {
            using (var context = new DataContext())
            {
                IRepository<Dock> dockRepository = new DockRepository(context);
                IRepository<Engineer> engineerRepository = new EngineerRepository(context);
                IRepository<Pilot> pilotRepository = new PilotRepository(context);
                IRepository<Ship> shipRepository = new ShipRepository(context);
                IRepository<Station> stationRepository = new StationRepository(context);

                var station = new Station
                                      {
                                          Name = StationName,
                                          Location = StationLocation
                                      };
                var dock = new Dock { Name = "First dock", CountOfShipsPlaces = 3 };
                var engineer = new Engineer
                                   {
                                       FirstName = "Ivan",
                                       MiddleName = "Ivanovich",
                                       LastName = "Ivanov",
                                       Biography = "Very powerfully engineer",
                                       Qualification = "Welder"
                                   };
                var pilot = new Pilot
                {
                    FirstName = "Raman",
                    MiddleName = "Igorevich",
                    LastName = "Dzianishchyk",
                    Biography = "Born in bla-bla-bla-blar",
                    ExperienceFlights = 3
                };
                var ship = new Ship { Name = "Impetuous" };

                station.Docks = new List<Dock>() { dock };
                station.Engineers = new List<Engineer>() { engineer };
                pilot.OwnShip = ship;
                ship.DockRegistry = dock;
                dock.Engineers = new List<Engineer>() { engineer };

                stationRepository.Add(station);
                dockRepository.Add(dock);
                engineerRepository.Add(engineer);
                pilotRepository.Add(pilot);
                shipRepository.Add(ship);

                Assert.IsTrue(
                    stationRepository.Count(null) > 0 && shipRepository.Count(null) > 0
                    && pilotRepository.Count(null) > 0 && engineerRepository.Count(null) > 0
                    && dockRepository.Count(null) > 0);
            }
        }

        /// <summary>
        /// The change entity.
        /// </summary>
        [TestMethod]
        public void ChangeEntity()
        {
            using (var context = new DataContext())
            {
                IRepository<Station> stationRepository = new StationRepository(context);

                Station station = stationRepository.Get(st => st.Name == StationName).First();

                station.Name = "New Station name";
                stationRepository.Update(station);

                Station newStation = stationRepository.Get(st => st.Id == station.Id).First();

                Assert.IsTrue(!newStation.Name.Equals(StationName));
            }
        }

        /// <summary>
        /// The delete entity.
        /// </summary>
        [TestMethod]
        public void DeleteEntity()
        {
            using (var context = new DataContext())
            {
                IRepository<Station> stationRepository = new StationRepository(context);
                Station station = stationRepository.Get(st => st.Location == StationLocation).First();

                int beforeCount = stationRepository.Count(null);

                stationRepository.Delete(station);

                int afterCount = stationRepository.Count(null);

                Assert.IsTrue(beforeCount != afterCount);
            }
        }
    }
}
