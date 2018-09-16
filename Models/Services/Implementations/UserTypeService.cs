using CoreApiEfCodeFirst.Models.Domain;
using CoreApiEfCodeFirst.Models.Repository.Implementations;
using CoreApiEfCodeFirst.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Services.Implementations
{
    public class UserTypeService : IGenericService<UserType> {

        private UserTypeRepository rep = new UserTypeRepository();

        public UserType Create(UserType toCreate) {

            try {
                rep.Create(toCreate);
                rep.Save();
                return toCreate;
            }
            catch (Exception) {

                return null;
            }
        }

        public bool Delete(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<UserType> FindBy(UserType filter) {
            try {

                if(filter == null) {
                    filter = new UserType();
                }
                return rep.FindBy(f => f.IsActive && f.Description.Contains
                (string.IsNullOrEmpty(filter.Description) ?
                    f.Description : filter.Description));

            }
            catch (Exception) {

                throw;
            }
        }

        public UserType Get(int id) {
            try {

                return rep.GetSingle(id);

            }
            catch (Exception) {

                return null;
            }
        }

        public UserType Update(UserType toUpdate) {
            throw new NotImplementedException();
        }
    }
}
