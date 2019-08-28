using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class ExerciseEquipmentRepository : IExerciseEquipmentRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper mapper;

        public ExerciseEquipmentRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            this.mapper = mapper;

        }
        public IExerciseEquipment Create(IExerciseEquipment exerciseEquipment)
        {
            exerciseEquipment.Id = Guid.NewGuid();
            exerciseEquipment.DateCreated = DateTime.UtcNow;
            exerciseEquipment.DateUpdated = DateTime.UtcNow;
            AppDbContext.ExerciseEquipment.Add(mapper.Map<ExerciseEquipment>(exerciseEquipment));
            AppDbContext.SaveChanges();
            return exerciseEquipment;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.ExerciseEquipment.Find(id);
            AppDbContext.ExerciseEquipment.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;

        }

        public PaginatedList<IExerciseEquipment> Find(IFilter filter)
        {
            IQueryable<ExerciseEquipment> exEquip = AppDbContext.ExerciseEquipment.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                exEquip = exEquip.Where(c => c.EquipmentId.Equals(filter.SearchQuery) || c.ExercisesId.Equals(filter.SearchQuery) || c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant())|| String.Format("{0:s}", c.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "exerciseid":
                    if (!filter.SortAscending)
                        exEquip = exEquip.OrderByDescending(c => c.ExercisesId);
                    else
                        exEquip = exEquip.OrderBy(c => c.ExercisesId);
                    break;

                case "equipmentid":
                    if (!filter.SortAscending)
                        exEquip = exEquip.OrderByDescending(c => c.EquipmentId);
                    else
                        exEquip = exEquip.OrderBy(c => c.EquipmentId);

                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        exEquip = exEquip.OrderByDescending(c => c.DateUpdated);
                    else
                        exEquip = exEquip.OrderBy(c => c.DateUpdated);

                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = exEquip.Count();

            var items = exEquip.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IExerciseEquipment>(mapper.Map<IEnumerable<IExerciseEquipment>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IExerciseEquipment Get(Guid id)
        {
            return mapper.Map<IExerciseEquipment>(AppDbContext.ExerciseEquipment.Find(id));
        }

        public bool Update(IExerciseEquipment exerciseEquipment)
        {
            if (AppDbContext.ExerciseEquipment.Find(exerciseEquipment).Id == exerciseEquipment.Id)
            {
                AppDbContext.ExerciseEquipment.Update(mapper.Map<ExerciseEquipment>(exerciseEquipment));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }
    }
}
