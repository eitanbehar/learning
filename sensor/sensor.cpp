#include "sensor.h"

bool sensor::get_state()
{
    return state;
}

void sensor::set()
{
    state = true;    
}

void sensor::clear()
{
    state = false;
}