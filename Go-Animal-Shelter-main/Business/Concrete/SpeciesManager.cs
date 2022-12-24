using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SpeciesManager : ISpeciesService
    {
        ISpeciesDal _speciesDal; 
        public SpeciesManager(ISpeciesDal speciesDal) { 
            _speciesDal= speciesDal;
        }
        public IResult Add(Species species)
        {
            _speciesDal.Add(species);
            return new SuccessResult("Species Added Successfully");
        }

        public IResult Delete(Species species)
        {
            _speciesDal.Delete(species);
            return new SuccessResult("Species Deleted Successfully");
        }

        public IDataResult<List<Species>> GetAll()
        {
            return new SuccessDataResult<List<Species>>(_speciesDal.GetAll(), "Species Listed Successfully"); 
        }

        public IResult Update(Species species)
        {
            _speciesDal.Update(species);
            return new SuccessResult("Species Updated Successfully");
        }
    }
}
