using System.Collections.Generic;
using get_set_full_stack.Models;

namespace get_set_full_stack.Repositories
{
    public interface IUserProfileRepository
    {
        void Add(UserProfile userProfile);
        UserProfile GetByFirebaseUserId(string firebaseUserId);
        List<UserProfile> GetAllUsers();
        UserProfile GetByUserId(int id);
    }
}
