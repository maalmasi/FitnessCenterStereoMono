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

    class ExercisesRepository : IExercisesRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper Mapper;

        public ExercisesRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            AppDbContext = dbContext;
            Mapper = mapper;

        }
        public IExercises Create(IExercises exercises)
        {
            exercises.Id = Guid.NewGuid();
            exercises.DateCreated = DateTime.UtcNow;
            exercises.DateUpdated = DateTime.UtcNow;
            AppDbContext.Exercises.Add(Mapper.Map<Exercises>(exercises));
            AppDbContext.SaveChanges();
            return exercises;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Exercises.Find(id);
            AppDbContext.Exercises.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IExercises> Find(IFilter filter)
        {
            IQueryable<Exercises> exercises = AppDbContext.Exercises.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                exercises = exercises.Where(exc =>exc.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant())  || exc.Id.Equals(filter.SearchQuery) || exc.DateUpdated.Equals(filter.SearchQuery) || exc.DateCreated.Equals(filter.SearchQuery));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        exercises = exercises.OrderByDescending(exc => exc.Name);
                    else
                        exercises = exercises.OrderBy(exc => exc.Name);

                    break;
                case "id":
                    if (!filter.SortAscending)
                        exercises = exercises.OrderByDescending(exc => exc.Id);
                    else
                        exercises = exercises.OrderBy(exc => exc.Id);
                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        exercises = exercises.OrderByDescending(exc => exc.DateUpdated);
                    else
                        exercises = exercises.OrderBy(exc => exc.DateUpdated);
                    break;

                case "datecreated":
                    if (!filter.SortAscending)
                        exercises = exercises.OrderByDescending(exc => exc.DateCreated);
                    else
                        exercises = exercises.OrderBy(exc => exc.DateCreated);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = exercises.Count();

            var items = exercises.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IExercises>(Mapper.Map<IEnumerable<IExercises>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IExercises Get(Guid id)
        {
            return Mapper.Map<IExercises>(AppDbContext.Exercises.Find(id));
        }

        public bool Update(IExercises exercises)
        {
            if (AppDbContext.Exercises.Find(exercises.Id) != null)
            {
                AppDbContext.Exercises.Update(Mapper.Map<Exercises>(exercises));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }
    }
}
