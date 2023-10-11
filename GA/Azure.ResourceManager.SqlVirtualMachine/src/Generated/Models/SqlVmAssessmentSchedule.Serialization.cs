// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmAssessmentSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(WeeklyInterval))
            {
                writer.WritePropertyName("weeklyInterval"u8);
                writer.WriteNumberValue(WeeklyInterval.Value);
            }
            if (Optional.IsDefined(MonthlyOccurrence))
            {
                writer.WritePropertyName("monthlyOccurrence"u8);
                writer.WriteNumberValue(MonthlyOccurrence.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime);
            }
            writer.WriteEndObject();
        }

        internal static SqlVmAssessmentSchedule DeserializeSqlVmAssessmentSchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enable = default;
            Optional<int> weeklyInterval = default;
            Optional<int> monthlyOccurrence = default;
            Optional<SqlVmAssessmentDayOfWeek> dayOfWeek = default;
            Optional<string> startTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("weeklyInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklyInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyOccurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyOccurrence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToSqlVmAssessmentDayOfWeek();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
            }
            return new SqlVmAssessmentSchedule(Optional.ToNullable(enable), Optional.ToNullable(weeklyInterval), Optional.ToNullable(monthlyOccurrence), Optional.ToNullable(dayOfWeek), startTime.Value);
        }
    }
}