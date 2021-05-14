// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for Timing
  /// </summary>
  public static class TimingJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Timing into JSON
    /// </summary>
    public static void SerializeJson(this Timing current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: Timing, Export: Timing, Base: BackboneElement (BackboneType)
      ((Hl7.Fhir.Model.BackboneType)current).SerializeJson(writer, options, false);

      if ((current.EventElement != null) && (current.EventElement.Count != 0))
      {
        writer.WritePropertyName("event");
        writer.WriteStartArray();
        foreach (FhirDateTime val in current.EventElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if (current.Repeat != null)
      {
        writer.WritePropertyName("repeat");
        current.Repeat.SerializeJson(writer, options);
      }

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Timing
    /// </summary>
    public static void DeserializeJson(this Timing current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Timing
    /// </summary>
    public static void DeserializeJsonProperty(this Timing current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "event":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.EventElement = new List<FhirDateTime>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.EventElement.Add(new FhirDateTime(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.EventElement.Count == 0)
          {
            current.EventElement = null;
          }

          break;

        case "repeat":
          current.Repeat = JsonSerializer.Deserialize<Hl7.Fhir.Model.Timing.RepeatComponent>(ref reader, options);

          break;

        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        // Complex: Timing, Export: Timing, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneType)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Timing#Repeat into JSON
    /// </summary>
    public static void SerializeJson(this Timing.RepeatComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if (current.Bounds != null)
      {
        switch (current.Bounds)
        {
          case Duration v_Duration:
            writer.WritePropertyName("boundsDuration");
            v_Duration.SerializeJson(writer, options);
            break;
          case Range v_Range:
            writer.WritePropertyName("boundsRange");
            v_Range.SerializeJson(writer, options);
            break;
          case Period v_Period:
            writer.WritePropertyName("boundsPeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if ((current.CountElement != null) && (current.CountElement.Value != null))
      {
        writer.WriteNumber("count",(int)current.CountElement.Value);
      }

      if ((current.CountMaxElement != null) && (current.CountMaxElement.Value != null))
      {
        writer.WriteNumber("countMax",(int)current.CountMaxElement.Value);
      }

      if ((current.DurationElement != null) && (current.DurationElement.Value != null))
      {
        writer.WriteNumber("duration",(decimal)current.DurationElement.Value);
      }

      if ((current.DurationMaxElement != null) && (current.DurationMaxElement.Value != null))
      {
        writer.WriteNumber("durationMax",(decimal)current.DurationMaxElement.Value);
      }

      if (current.DurationUnitElement != null)
      {
        writer.WriteString("durationUnit",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.DurationUnitElement.Value));
      }

      if ((current.FrequencyElement != null) && (current.FrequencyElement.Value != null))
      {
        writer.WriteNumber("frequency",(int)current.FrequencyElement.Value);
      }

      if ((current.FrequencyMaxElement != null) && (current.FrequencyMaxElement.Value != null))
      {
        writer.WriteNumber("frequencyMax",(int)current.FrequencyMaxElement.Value);
      }

      if ((current.PeriodElement != null) && (current.PeriodElement.Value != null))
      {
        writer.WriteNumber("period",(decimal)current.PeriodElement.Value);
      }

      if ((current.PeriodMaxElement != null) && (current.PeriodMaxElement.Value != null))
      {
        writer.WriteNumber("periodMax",(decimal)current.PeriodMaxElement.Value);
      }

      if (current.PeriodUnitElement != null)
      {
        writer.WriteString("periodUnit",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.PeriodUnitElement.Value));
      }

      if ((current.DayOfWeekElement != null) && (current.DayOfWeekElement.Count != 0))
      {
        writer.WritePropertyName("dayOfWeek");
        writer.WriteStartArray();
        foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DayOfWeekElement)
        {
          writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
        }
        writer.WriteEndArray();
      }

      if ((current.TimeOfDayElement != null) && (current.TimeOfDayElement.Count != 0))
      {
        writer.WritePropertyName("timeOfDay");
        writer.WriteStartArray();
        foreach (Time val in current.TimeOfDayElement)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.WhenElement != null) && (current.WhenElement.Count != 0))
      {
        writer.WritePropertyName("when");
        writer.WriteStartArray();
        foreach (Code<Hl7.Fhir.Model.Timing.EventTiming> val in current.WhenElement)
        {
          writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
        }
        writer.WriteEndArray();
      }

      if ((current.OffsetElement != null) && (current.OffsetElement.Value != null))
      {
        writer.WriteNumber("offset",(int)current.OffsetElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Timing#Repeat
    /// </summary>
    public static void DeserializeJson(this Timing.RepeatComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Timing#Repeat
    /// </summary>
    public static void DeserializeJsonProperty(this Timing.RepeatComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "boundsDuration":
          current.Bounds = JsonSerializer.Deserialize<Hl7.Fhir.Model.Duration>(ref reader, options);
          break;

        case "boundsRange":
          current.Bounds = JsonSerializer.Deserialize<Hl7.Fhir.Model.Range>(ref reader, options);
          break;

        case "boundsPeriod":
          current.Bounds = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "count":
          current.CountElement = new PositiveInt(reader.GetInt32());

          break;

        case "countMax":
          current.CountMaxElement = new PositiveInt(reader.GetInt32());

          break;

        case "duration":
          current.DurationElement = new FhirDecimal(reader.GetDecimal());

          break;

        case "durationMax":
          current.DurationMaxElement = new FhirDecimal(reader.GetDecimal());

          break;

        case "durationUnit":
          current.DurationUnitElement =new Code<Hl7.Fhir.Model.Timing.UnitsOfTime>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Timing.UnitsOfTime>(reader.GetString()));

          break;

        case "frequency":
          current.FrequencyElement = new PositiveInt(reader.GetInt32());

          break;

        case "frequencyMax":
          current.FrequencyMaxElement = new PositiveInt(reader.GetInt32());

          break;

        case "period":
          current.PeriodElement = new FhirDecimal(reader.GetDecimal());

          break;

        case "periodMax":
          current.PeriodMaxElement = new FhirDecimal(reader.GetDecimal());

          break;

        case "periodUnit":
          current.PeriodUnitElement =new Code<Hl7.Fhir.Model.Timing.UnitsOfTime>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Timing.UnitsOfTime>(reader.GetString()));

          break;

        case "dayOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DayOfWeekElement = new List<Code<Hl7.Fhir.Model.DaysOfWeek>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DayOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DaysOfWeek>(reader.GetString())));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.DayOfWeekElement.Count == 0)
          {
            current.DayOfWeekElement = null;
          }

          break;

        case "timeOfDay":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.TimeOfDayElement = new List<Time>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.TimeOfDayElement.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Time>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.TimeOfDayElement.Count == 0)
          {
            current.TimeOfDayElement = null;
          }

          break;

        case "when":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.WhenElement = new List<Code<Hl7.Fhir.Model.Timing.EventTiming>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.WhenElement.Add(new Code<Hl7.Fhir.Model.Timing.EventTiming>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Timing.EventTiming>(reader.GetString())));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.WhenElement.Count == 0)
          {
            current.WhenElement = null;
          }

          break;

        case "offset":
          current.OffsetElement = new UnsignedInt(reader.GetInt32());

          break;

      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class TimingJsonConverter : JsonConverter<Timing>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Timing).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Timing value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Timing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Timing target = new Timing();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
