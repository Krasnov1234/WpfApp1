using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class management_workout
    {

        public void Insert(string work)
        {
            dbSportzal db = new dbSportzal();
            workout workouts = new workout();
            workouts.workout1 = txtWorkout.Text;
            db.workout.Add(workouts);
            db.workout.ToList();
            db.SaveChanges();
            Table.ItemsSource = db.workout.ToList();

        }

    }
}
