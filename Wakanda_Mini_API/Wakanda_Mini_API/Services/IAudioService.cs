using Wakanda_Mini_API.Models;

namespace Wakanda_Mini_API.Services
{
    public interface IAudioService
    {
        public Audio Create(Audio audio);
        public Audio Get(Audio audio);

        public Audio Update(Audio audio);
        public Audio Delete(Audio audio);

    }
}
