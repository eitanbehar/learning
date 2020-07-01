#include "room.h"

void room::set_sensor_entry()
{    
    // check exit sensor to detect someone going out
    if (sensor_exit.get_state())
    {
        people_in_room--;        
        sensor_exit.clear();
    }
    else
    {
        sensor_entry.set(); // save state
    }        
}

void room::set_sensor_exit()
{
    // check entry sensor to detect someone going out
    if (sensor_entry.get_state())
    {
        people_in_room++;        
        sensor_entry.clear();
    }
    else
    {
        sensor_exit.set(); // save state
    } 
}