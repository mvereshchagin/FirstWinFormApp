using Data.Settings;

namespace Data.Repositories;

public interface ISettingsProvider<T>
{
    T Read();

    void Update(T settings);
}
