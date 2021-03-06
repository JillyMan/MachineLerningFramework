﻿namespace MachineLearning.DataLayer
{
    public interface IJsonSerializer
    {
        string Serialize(object obj);

        T Deserialize<T>(string obj) where T : class;
    }
}
