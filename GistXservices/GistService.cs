using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices
{
    public class GistService : IGistService
    {
        public ResponseContract CreateGist(string title, string content, int userId)
        {
            using(var context = new MyDbContext())
            {
                var gist = new Gist
                {
                    Title = title,
                    Content = content,
                    UserId = userId,
                    CreatedAt = DateTime.Now
                };

                context.Gists.Add(gist);
                context.SaveChanges();

                return new ResponseContract
                {
                    status = 1,
                    message = "Gist created",
                    id = gist.Id
                };
            }
        }
        public ResponseContract DeleteGist(int id)
        {
               using (var context = new MyDbContext())
            {
                 var gist = context.Gists.FirstOrDefault(g => g.Id == id);
                 if (gist == null)
                {
                      return new ResponseContract
                      {
                            status = 0,
                            message = "Gist not found",
                            id = 0
                      };
                 }
    
                 context.Gists.Remove(gist);
                 context.SaveChanges();
    
                 return new ResponseContract
                 {
                      status = 1,
                      message = "Gist deleted",
                      id = 0
                 };
                }       
        }
        public GistMessage GetGist(int id)
        {
             using (var context = new MyDbContext())
            {
                var gist = context.Gists.FirstOrDefault(g => g.Id == id);
                if (gist == null)
                {
                    return new GistMessage
                    {
                        Id = 0,
                        Title = "Gist not found"
                    };
                }

                return new GistMessage
                {
                    Id = gist.Id,
                    Title = gist.Title,
                    Content = gist.Content
                };
            }
        }

        public List<Gist> GetGists(int userId)
        { 
            using (var context = new MyDbContext())
            {
                return context.Gists.Where(g => g.UserId == userId).ToList();
            }
        }

        public ResponseContract AddUserToGist(int gistId, int userId)
        {
             using (var context = new MyDbContext())
            {
                var gist = context.Gists.FirstOrDefault(g => g.Id == gistId);
                if (gist == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "Gist not found",
                        id = 0
                    };
                }

                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "User not found",
                        id = 0
                    };
                }

                var gistUser = new GistUser
                {
                    GistId = gistId,
                    UserId = userId
                };

                context.GistUsers.Add(gistUser);
                context.SaveChanges();

                return new ResponseContract
                {
                    status = 1,
                    message = "User added to gist",
                    id = 0
                };
            }
        }

        public ResponseContract ForkGist(int gistId, int userId)
        {
            using (var context = new MyDbContext())
            {
                var gist = context.Gists.FirstOrDefault(g => g.Id == gistId);
                if (gist == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "Gist not found",
                        id = 0
                    };
                }

                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "User not found",
                        id = 0
                    };
                }

                var fork = new Fork
                {
                    GistId = gistId,
                    UserId = userId
                };

                context.Forks.Add(fork);
                context.SaveChanges();

                return new ResponseContract
                {
                    status = 1,
                    message = "Gist forked",
                    id = 0
                };
            }
        }

        public List<Gist> GetForks(int gistId)
        {  
            using (var context = new MyDbContext())
            {
                return context.Forks.Where(f => f.GistId == gistId).Select(f => f.Gist).ToList();
            }
        }

        public List<User> GetGistUsers(int gistId)
        {
            using (var context = new MyDbContext())
            {
                return context.GistUsers.Where(gu => gu.GistId == gistId).Select(gu => gu.User).ToList();
            }
        }

        
        public ResponseContract RemoveUserFromGist(int gistId, int userId)
        {
            using (var context = new MyDbContext())
            {
                var gistUser = context.GistUsers.FirstOrDefault(gu => gu.GistId == gistId && gu.UserId == userId);
                if (gistUser == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "User not found in gist",
                        id = 0
                    };
                }

                context.GistUsers.Remove(gistUser);
                context.SaveChanges();

                return new ResponseContract
                {
                    status = 1,
                    message = "User removed from gist",
                    id = 0
                };
            }
        }

        public ResponseContract UpdateGist(int id, string title, string content)
        {
            using (var context = new MyDbContext())
            {
                var gist = context.Gists.FirstOrDefault(g => g.Id == id);
                if (gist == null)
                {
                    return new ResponseContract
                    {
                        status = 0,
                        message = "Gist not found",
                        id = 0
                    };
                }

                gist.Title = title;
                gist.Content = content;
                gist.UpdatedAt = DateTime.Now;

                context.SaveChanges();

                return new ResponseContract
                {
                    status = 1,
                    message = "Gist updated",
                    id = id
                };
            }
        }
    }
}
