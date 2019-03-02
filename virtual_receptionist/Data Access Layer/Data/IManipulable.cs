﻿namespace virtual_receptionist.DataAccessLayer.Data
{
    /// <summary>
    /// Adatmanipulációt objektumokon leíró generikus interfész
    /// </summary>
    /// <typeparam name="T">Típus</typeparam>
    public interface IManipulable<T> where T : class
    {
        /// <summary>
        /// Új elem létrehozása
        /// </summary>
        /// <param name="entity">Egyed</param>
        void Create(T entity);

        /// <summary>
        /// Meglévő elem módosítása
        /// </summary>
        /// <param name="entity">Egyed</param>
        void Update(T entity);

        /// <summary>
        /// Meglévő elem törlése
        /// </summary>
        /// <param name="entity">Egyed</param>
        void Delete(T entity);
    }
}
