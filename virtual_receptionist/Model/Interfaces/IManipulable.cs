namespace virtual_receptionist.Model.Interfaces
{
    /// <summary>
    /// CRUD metódusokat leíró interfész
    /// </summary>
    public interface IManipulable<T> where T : class
    {
        /// <summary>
        /// Új elem létrehozása
        /// </summary>
        /// <typeparam name="T">Típus</typeparam>
        /// <param name="item">Típusú elem</param>
        void Create(T item);

        /// <summary>
        /// Meglévő elem módosítása
        /// </summary>
        /// <typeparam name="T">Típus</typeparam>
        /// <param name="item">Típusú elem</param>
        void Update(T item);

        /// <summary>
        /// Meglévő elem törlése
        /// </summary>
        /// <typeparam name="T">Típus</typeparam>
        /// <param name="item">Típusú elem</param>
        void Delete(T item);
    }
}
