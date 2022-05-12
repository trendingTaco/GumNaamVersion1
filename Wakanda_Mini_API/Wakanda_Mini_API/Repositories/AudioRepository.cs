using Wakanda_Mini_API.Models;

namespace Wakanda_Mini_API.Repositories
{
    public class AudioRepository
    {
        public Audio Create(Audio audio)
        {
            return new Audio();
        }

        public Audio Get(Audio audio)
        {

            return audio;
        }

        public Audio Update(Audio audio)
        {
            return audio;
        }
    }
}
