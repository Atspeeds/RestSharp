using RestSharp;
using RestSharpCourses.Dto;
using System.Collections;
using System.Collections.Generic;

namespace RestSharpCourses
{
    public class UsersContext
    {

        RestClient client = new RestClient("https://jsonplaceholder.typicode.com");

        public List<UserDto> GetUser()
        {

            RestRequest request = new RestRequest("/users", Method.Get);
            var resualt = client.Get<List<UserDto>>(request);

            return resualt;
        }

        public UserDto GetUser(int id)
        {
            RestRequest request = new RestRequest($"/users/{id}", Method.Post);
           
            var resualt = client.Get<UserDto>(request);
            return resualt;
        }




    }
}
