using FluentValidation.Results;
using medicineStock.Business.Abstractions;
using medicineStock.Business.Validators;
using medicineStock.DataAccess.Context;
using medicineStock.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace medicineStock.Business.Services
{
    public class UserService : IManager<User>
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository uRepo)
        {
            _userRepository = uRepo;
        }
        public void Create(User entity)
        {
            if (IfEntityExists(u => u.TCno == entity.TCno))
            {
                throw new Exception("Bu kullanıcı daha önce kaydedilmiştir.");
            }
            UserValidator uVal = new UserValidator();
            ValidationResult result = uVal.Validate(entity);
            StringBuilder stringBuilder = new StringBuilder();
            result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                throw new Exception(stringBuilder.ToString());
            }

            _userRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _userRepository.Delete(Id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetByID(Guid Id)
        {
            return _userRepository.GetById(Id);
        }

        public bool IfEntityExists(Expression<Func<User, bool>> filter)
        {
            return _userRepository.IfEntityExists(filter);
        }

        public void Update(User entity)
        {
            if (entity != null)
            {
                _userRepository.Update(entity);
            }
        }
    }
}
