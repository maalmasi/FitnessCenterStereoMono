using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    internal class EquipmentRepository : IEquipmentRepository
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public EquipmentRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected ApplicationDbContext AppDbContext { get; private set; }

        #endregion Properties

        #region Methods

        public IEquipment Create(IEquipment equipment)
        {
            equipment.Id = Guid.NewGuid();
            equipment.DateCreated = DateTime.UtcNow;
            equipment.DateUpdated = DateTime.UtcNow;
            AppDbContext.Equipment.Add(mapper.Map<Equipment>(equipment));
            AppDbContext.SaveChanges();
            return equipment;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Equipment.Find(id);
            AppDbContext.Equipment.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IEquipment> Find(IFilter filter)
        {
            IQueryable<Equipment> equipment = AppDbContext.Equipment.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                equipment = equipment.Where(c => c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        equipment = equipment.OrderByDescending(c => c.Name);
                    else
                        equipment = equipment.OrderBy(c => c.Name);

                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        equipment = equipment.OrderByDescending(c => c.DateUpdated);
                    else
                        equipment = equipment.OrderBy(c => c.DateUpdated);

                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = equipment.Count();

            var items = equipment.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();

            return new PaginatedList<IEquipment>(mapper.Map<IEnumerable<IEquipment>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IEquipment Get(Guid id)
        {
            return mapper.Map<IEquipment>(AppDbContext.Equipment.Find(id));
        }

        public bool Update(IEquipment equipment)
        {
            if (AppDbContext.Equipment.Find(equipment).Id == equipment.Id)
            {
                AppDbContext.Equipment.Update(mapper.Map<Equipment>(equipment));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }

        #endregion Methods
    }
}