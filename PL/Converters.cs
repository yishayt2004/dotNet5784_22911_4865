﻿using BlApi;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Dal;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PL;

class ConvertIdToContent : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (int)value == 0 ? "Add" : "Update"; // if the value is equal to 0 return "Add" else return "Update"
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

class ConverIdToContentKey : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (int)value == 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
class ConevrLastInListToInt : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var tempList = (List<BO.Dependcys>)value;
        var list = tempList.Select(t => Factory.Get().Task.Read(t.Id)); // Get all the tasks from the list

        // Find the task with the latest end time using MaxBy extension method
        var latestTask = list.MaxBy(t => t.StartDate + t.RequiredEffort);

        // Return the ID of the task with the latest end time
        return latestTask?.Id ; // Return -1 if latestTask is null
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}



class ConerterReq : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is List<DO.Task> tasks)
        {
           var temp = tasks.Select(t => Factory.Get().Task.Read(t.Id));
            var latestTask = temp.MaxBy(t => t.StartDate + t.RequiredEffort);
            return latestTask?.StartDate + latestTask?.RequiredEffort;
        }
        else if (value is List<BO.Dependcys> dependencies)
        {
            var temp = dependencies.Select(t => Factory.Get().Task.Read(t.Id));
            var latestTask = temp.MaxBy(t => t.StartDate + t.RequiredEffort);
            return latestTask?.StartDate + latestTask?.RequiredEffort;
            
        }
        else
        {
            throw new InvalidOperationException("Unsupported type");
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

class ConvertEffortTimeToWidthKey : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
       TimeSpan requiredEffortTime = (TimeSpan)value ;
        return requiredEffortTime.TotalDays*2;       
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
class ConvertStartDateToMargin : IValueConverter
{
    private IDal _dal = DalApi.Factory.Get; // create a new instance of the DAL layer to use its functions to implement the BL layer functions like Create, Delete, Read, ReadAll, and Update

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        DateTime ScheduledTime = (DateTime)value;
        DateTime? startTimeDateOfProject = _dal.ischedule.GetProjectStartDateTime();

        if (startTimeDateOfProject.HasValue)
        {
            // Calculate the difference between ScheduledTime and currentDate in days
            double daysDifference = (ScheduledTime - startTimeDateOfProject.Value).TotalDays;

            // Create a Thickness object based on the difference
            return new Thickness(daysDifference * 20, 0, 0, 0);
        }
        else
        {
            // If currentDate is null, return a default Thickness object
            return new Thickness(0, 0, 0, 0);
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
