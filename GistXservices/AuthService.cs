using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GistXservices
{
    public class AuthService : IService
    {
        public ResponseContract Register(string username, string email, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return new ResponseContract
                {
                    status = 0,
                    message = "All fields are required"
                };
            }

            if(username.Length < 3)
            {
                return new ResponseContract
                {
                    status = 0,
                    message = "Username must be at least 3 characters"
                };
            }

            if(password.Length < 8)
            {
                return new ResponseContract
                {
                    status = 0,
                    message = "Password must be at least 8 characters"
                };
            }

            using (var context = new MyDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if(user != null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "Username already exists"
                    };
                }

                user = context.Users.FirstOrDefault(u => u.Email == email);
                if(user != null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "Email already exists"
                    };
                }
                
                user = new User
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    CreatedAt = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();

            }

            return new ResponseContract
            {
                status = 1,
                message = "User registered successfully"
            };
        }

        public ResponseContract Login(string email, string password)
        {
            using (var context = new MyDbContext())
            {
              if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                  return new ResponseContract
                  {
                      status = 0,
                      message = "All fields are required"
                  };
              }
              var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                if(user == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "Invalid username or password"
                    };
                }

                return new ResponseContract
                {
                    status = 1,
                    message = "Login successful"
                };
            }
        }   
    }
}
