using BenchmarkDotNet.Attributes;
using BenchmarkTest.Cons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.Cons.Benchmarks;
public class ManipulateStudentRecord
{
    public StudentRecord ManipulateStudentRecordPropertyInfo(StudentRecord obj, string operation, string prop, string newValue)
    {
        if (operation == "delete")
        {
            var propertyInfo = obj.GetType().GetProperty(prop);
            propertyInfo!.SetValue(obj, string.Empty, null);
        }
        else if (operation == "edit")
        {
            var propertyInfo = obj.GetType().GetProperty(prop);
            propertyInfo!.SetValue(obj, newValue, null);
        }

        return obj;
    }



    public StudentRecord ManipulateStudentRecordSwitch(StudentRecord obj, string operation, string prop, string newValue)
    {
        var newObj = new StudentRecord
        {
            Name = obj.Name,
            LastName = obj.LastName,
            City = obj.City
        };

        switch (operation)
        {
            case "delete":
                SwitchCase(prop, newObj, string.Empty);
                break;
            case "edit":
                SwitchCase(prop, newObj, newValue);
                break;
            default:
                break;
        }

        return newObj;
    }

    public StudentRecord ManipulateStudentRecordSwitchWithoutNewObj(StudentRecord obj, string operation, string prop, string newValue)
    {
        switch (operation)
        {
            case "delete":
                SwitchCase(prop, obj, string.Empty);
                break;
            case "edit":
                SwitchCase(prop, obj, newValue);
                break;
            default:
                break;
        }

        return obj;
    }

    private static void SwitchCase(string prop, StudentRecord obj, string newString)
    {
        switch (prop)
        {
            case "Name":
                obj.Name = newString;
                break;
            case "LastName":
                obj.LastName = newString;
                break;
            case "City":
                obj.City = newString;
                break;
            default:
                break;
        }
    }

    public StudentRecord ManipulateStudentRecordReviewer(StudentRecord obj, string operation, string prop, string newValue)
    {
        if (prop == "Name" || prop == "LastName" || prop == "City")
        {
            var newObj = new StudentRecord
            {
                Name = obj.Name,
                LastName = obj.LastName,
                City = obj.City
            };

            if (operation == "delete")
            {
                if (prop == "Name")
                    newObj.Name = string.Empty;
                else if (prop == "LastName")
                    newObj.LastName = string.Empty;
                else if (prop == "City")
                    newObj.City = string.Empty;
            }
            else if (operation == "edit")
            {
                if (prop == "Name")
                    newObj.Name = newValue;
                else if (prop == "LastName")
                    newObj.LastName = newValue;
                else if (prop == "City")
                    newObj.City = newValue;
            }

            return newObj;
        }

        return obj;
    }
}
