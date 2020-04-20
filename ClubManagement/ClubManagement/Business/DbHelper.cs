using ClubManagement.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClubManagement.Business
{
    public class DbHelper : IDisposable
    {
        #region Fields
        // Variable and Property needed to do Singleton
        private static DbHelper instance_;

        private string FileNameWithPath_ { get; set; }

        private SQLiteConnection Connection { get; set; }

        private SQLiteAsyncConnection ConnectionAsync { get; set; }
        #endregion

        #region Private methods
        private DbHelper(string fileNameWithPath)
        {
            FileNameWithPath_ = fileNameWithPath;
        }

        private void CheckConnectionExists(bool isAsync = false)
        {
            if (isAsync)
                ConnectionAsync = ConnectionAsync ?? GetConnectionAsync(FileNameWithPath_);
            else
                Connection = Connection ?? DependencyService.Get<ISqLite>().GetConnection(FileNameWithPath_);
        }

        private SQLiteConnection GetConnection(string fileNameWithPath)
        {
            var sqliteFilename = fileNameWithPath + ".db3";

            //var param = new SQLiteConnectionString(sqliteFilename, false);
            var connection = new SQLiteConnection(sqliteFilename);
            return connection;
        }
        private SQLiteAsyncConnection GetConnectionAsync(string fileNameWithPath)
        {
            var sqliteFilename = fileNameWithPath + ".db3";

            //var param = new SQLiteConnectionString(sqliteFilename, false);
            var connection = new SQLiteAsyncConnection(sqliteFilename);
            return connection;
        }
        /// <summary>
        /// Create tables
        /// </summary>
        private void CreateTables()
        {
            CheckConnectionExists();
            Connection?.CreateTable<Schedule>();
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Static method to get the instance's reference
        /// </summary>
        /// <param name="fileNameWithPath"></param>
        /// <returns></returns>
        public static DbHelper GetInstance(string fileNameWithPath)
        {
            if (fileNameWithPath == null
            || fileNameWithPath == String.Empty)
                throw new Exception("File name can't be empty");
            if (instance_ == null)
                instance_ = new DbHelper(fileNameWithPath);
            if (instance_ != null && !instance_.FileNameWithPath_.Equals(fileNameWithPath))
                throw new Exception("An instance already exists with a difference file path");
            instance_?.CreateTables();
            return instance_;
        }
        /// <summary>
        /// Insert an object
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="obj">Oject to be inserted</param>
        public void Insert<T>(T obj)
        {
            CheckConnectionExists();
            Connection?.Insert(obj);
        }
        /// <summary>
        /// Insert an object asynchronously
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="obj">Oject to be inserted</param>
        public void InsertAsync<T>(T obj)
        {
            CheckConnectionExists(true);
            ConnectionAsync?.InsertAsync(obj);
        }
        /// <summary>
        /// Insert a list of objects
        /// </summary>
        /// <typeparam name="T">Type of the objects</typeparam>
        /// <param name="objs">List of objects to be inserted</param>
        public void InsertAll<T>(IEnumerable<T> objs)
        {
            CheckConnectionExists();
            Connection?.InsertAll(objs);
        }
        /// <summary>
        /// Insert a list of objects asynchronously
        /// </summary>
        /// <typeparam name="T">Type of the objects</typeparam>
        /// <param name="objs">List of objects to be inserted</param>
        public void InsertAllAsync<T>(IEnumerable<T> objs)
        {
            CheckConnectionExists(true);
            ConnectionAsync?.InsertAllAsync(objs);
        }
        /// <summary>
        /// Get all schedules objects
        /// </summary>
        /// <returns>A list of schedules</returns>
        public IQueryable<Schedule> GetSchedules()
        {
            return Connection.Table<Schedule>().AsQueryable();
        }
        public void UpdateSchedule(Schedule schedule)
        {
            Connection.Update(schedule);
        }
        #endregion

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
