using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Task33_AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        private IMapper _mapper;
        private IUserRepository _userRepository;
        public UserController(ILogger logger, IMapper mapper, IUserRepository userRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _userRepository = userRepository;
            _logger.WriteEvent("Сообщение о событии в программе");
            _logger.WriteError("Сообщение об ошибке в программе");
        }

        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Email = "ivanov@mail.ru",
                FirstName = "Ivan",
                LastName = "Ivanov",
                Login = "vanya",
                Password = "qwe123",
            };
        }
        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };

            var userViewModel = _mapper.Map<UserViewModel>(user);

            return userViewModel;
        }
        [HttpGet]
        [Route("allusers")]
        public IEnumerable<User> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            return users;
        }
        [HttpGet]
        [Route("getUserByLogin")]
        public User GetUserByLogin(string login)
        {
            return _userRepository.GetByLogin(login);
        }

    }
}
