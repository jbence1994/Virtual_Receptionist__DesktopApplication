namespace virtual_receptionist.Model.Interfaces
{
    /// <summary>
    /// CRUD metódusokat leíró interfész
    /// </summary>
    public interface IManipulable
    {
        /// <summary>
        /// Új elem létrehozása
        /// </summary>
        /// <typeparam name="T">Típus</typeparam>
        /// <param name="item">Típusú elem</param>
        void Create<T>(T item) where T : class;

        /// <summary>
        /// Meglévő elem módosítása
        /// </summary>
        /// <typeparam name="T">Típus</typeparam>
        /// <param name="item">Típusú elem</param>
        void Update<T>(T item) where T : class;

        /// <summary>
        /// Meglévő elem törlése
        /// </summary>
        /// <typeparam name="T">Típus</typeparam>
        /// <param name="item">Típusú elem</param>
        void Delete<T>(T item) where T : class;
    }
}
