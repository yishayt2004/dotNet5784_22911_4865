﻿using DO;

namespace Dal;
internal static class DataSource
{
    public static object Engineers { get; internal set; }
    internal static List<DO.Engineer> engineers { get; } = new();
    internal static List<DO.Task> Tasks { get; } = new();
    internal static List<DO.Depandency> Depandencys { get; } = new();

    internal static object EngineersAdd(Engineer item)
    {
        throw new NotImplementedException();
    }

    internal static class Config 
    {
        internal const int startId = 1;
        private static int nextId = startId;
        internal static int NextId { get => nextId++; }
    }


    }

