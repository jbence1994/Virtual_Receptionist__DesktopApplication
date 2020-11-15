using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    public class RoomRepository : Repository
    {
        private readonly List<Room> rooms;

        public RoomRepository()
        {
            rooms = new List<Room>();
        }

        private void UploadRoomsList()
        {
            const string sql =
                "SELECT room.ID, room.Name, room.Number, billing_item.BillingItemName, room.Capacity FROM room, billing_item WHERE room.Category = billing_item.ID ORDER BY room.Number ASC";

            var dt = Database.Dql(sql);

            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToInt32(row["ID"]);
                var name = row["Name"].ToString();
                var number = Convert.ToInt32(row["Number"]);
                var category = row["BillingItemName"].ToString();
                var capacity = Convert.ToInt32(row["Capacity"]);

                var room = new Room
                {
                    Id = id,
                    Name = name,
                    Number = number,
                    Category = category,
                    Capacity = capacity
                };

                rooms.Add(room);
            }
        }

        public List<Room> GetRooms()
        {
            if (rooms.Count == 0)
                UploadRoomsList();

            return rooms;
        }

        public int GetRoomCapacity(int roomNumber)
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            return (from room in rooms where room.Number == roomNumber select room.Capacity).FirstOrDefault();
        }
    }
}
