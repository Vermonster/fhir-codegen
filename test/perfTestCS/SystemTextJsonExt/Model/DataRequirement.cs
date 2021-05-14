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
  /// JSON Serialization Extensions for DataRequirement
  /// </summary>
  public static class DataRequirementJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR DataRequirement into JSON
    /// </summary>
    public static void SerializeJson(this DataRequirement current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("type",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.TypeElement.Value));

      if ((current.ProfileElement != null) && (current.ProfileElement.Count != 0))
      {
        writer.WritePropertyName("profile");
        writer.WriteStartArray();
        foreach (Canonical val in current.ProfileElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if (current.Subject != null)
      {
        switch (current.Subject)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("subjectCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("subjectReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if ((current.MustSupportElement != null) && (current.MustSupportElement.Count != 0))
      {
        writer.WritePropertyName("mustSupport");
        writer.WriteStartArray();
        foreach (FhirString val in current.MustSupportElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.CodeFilter != null) && (current.CodeFilter.Count != 0))
      {
        writer.WritePropertyName("codeFilter");
        writer.WriteStartArray();
        foreach (DataRequirement.CodeFilterComponent val in current.CodeFilter)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.DateFilter != null) && (current.DateFilter.Count != 0))
      {
        writer.WritePropertyName("dateFilter");
        writer.WriteStartArray();
        foreach (DataRequirement.DateFilterComponent val in current.DateFilter)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.LimitElement != null) && (current.LimitElement.Value != null))
      {
        writer.WriteNumber("limit",(int)current.LimitElement.Value);
      }

      if ((current.Sort != null) && (current.Sort.Count != 0))
      {
        writer.WritePropertyName("sort");
        writer.WriteStartArray();
        foreach (DataRequirement.SortComponent val in current.Sort)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement
    /// </summary>
    public static void DeserializeJson(this DataRequirement current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR DataRequirement
    /// </summary>
    public static void DeserializeJsonProperty(this DataRequirement current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.TypeElement =new Code<Hl7.Fhir.Model.FHIRAllTypes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.FHIRAllTypes>(reader.GetString()));

          break;

        case "profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ProfileElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ProfileElement.Add(new Canonical(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ProfileElement.Count == 0)
          {
            current.ProfileElement = null;
          }

          break;

        case "subjectCodeableConcept":
          current.Subject = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);
          break;

        case "subjectReference":
          current.Subject = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);
          break;

        case "mustSupport":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.MustSupportElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.MustSupportElement.Add(new FhirString(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.MustSupportElement.Count == 0)
          {
            current.MustSupportElement = null;
          }

          break;

        case "codeFilter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.CodeFilter = new List<DataRequirement.CodeFilterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.CodeFilter.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.DataRequirement.CodeFilterComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.CodeFilter.Count == 0)
          {
            current.CodeFilter = null;
          }

          break;

        case "dateFilter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DateFilter = new List<DataRequirement.DateFilterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DateFilter.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.DataRequirement.DateFilterComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.DateFilter.Count == 0)
          {
            current.DateFilter = null;
          }

          break;

        case "limit":
          current.LimitElement = new PositiveInt(reader.GetInt32());

          break;

        case "sort":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Sort = new List<DataRequirement.SortComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Sort.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.DataRequirement.SortComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Sort.Count == 0)
          {
            current.Sort = null;
          }

          break;

      }
    }

    /// <summary>
    /// Serialize a FHIR DataRequirement#CodeFilter into JSON
    /// </summary>
    public static void SerializeJson(this DataRequirement.CodeFilterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if ((current.PathElement != null) && (current.PathElement.Value != null))
      {
        writer.WriteString("path",current.PathElement.Value);
      }

      if ((current.SearchParamElement != null) && (current.SearchParamElement.Value != null))
      {
        writer.WriteString("searchParam",current.SearchParamElement.Value);
      }

      if ((current.ValueSetElement != null) && (current.ValueSetElement.Value != null))
      {
        writer.WriteString("valueSet",current.ValueSetElement.Value);
      }

      if ((current.Code != null) && (current.Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();
        foreach (Coding val in current.Code)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#CodeFilter
    /// </summary>
    public static void DeserializeJson(this DataRequirement.CodeFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR DataRequirement#CodeFilter
    /// </summary>
    public static void DeserializeJsonProperty(this DataRequirement.CodeFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          current.PathElement = new FhirString(reader.GetString());

          break;

        case "searchParam":
          current.SearchParamElement = new FhirString(reader.GetString());

          break;

        case "valueSet":
          current.ValueSetElement = new Canonical(reader.GetString());

          break;

        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Code = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Code.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Coding>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Code.Count == 0)
          {
            current.Code = null;
          }

          break;

      }
    }

    /// <summary>
    /// Serialize a FHIR DataRequirement#DateFilter into JSON
    /// </summary>
    public static void SerializeJson(this DataRequirement.DateFilterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if ((current.PathElement != null) && (current.PathElement.Value != null))
      {
        writer.WriteString("path",current.PathElement.Value);
      }

      if ((current.SearchParamElement != null) && (current.SearchParamElement.Value != null))
      {
        writer.WriteString("searchParam",current.SearchParamElement.Value);
      }

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("valueDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("valuePeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case Duration v_Duration:
            writer.WritePropertyName("valueDuration");
            v_Duration.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#DateFilter
    /// </summary>
    public static void DeserializeJson(this DataRequirement.DateFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR DataRequirement#DateFilter
    /// </summary>
    public static void DeserializeJsonProperty(this DataRequirement.DateFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          current.PathElement = new FhirString(reader.GetString());

          break;

        case "searchParam":
          current.SearchParamElement = new FhirString(reader.GetString());

          break;

        case "valueDateTime":
          current.Value = new FhirDateTime(reader.GetString());
          break;

        case "valuePeriod":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "valueDuration":
          current.Value = JsonSerializer.Deserialize<Hl7.Fhir.Model.Duration>(ref reader, options);
          break;

      }
    }

    /// <summary>
    /// Serialize a FHIR DataRequirement#Sort into JSON
    /// </summary>
    public static void SerializeJson(this DataRequirement.SortComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("path",current.PathElement.Value);

      writer.WriteString("direction",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.DirectionElement.Value));

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#Sort
    /// </summary>
    public static void DeserializeJson(this DataRequirement.SortComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR DataRequirement#Sort
    /// </summary>
    public static void DeserializeJsonProperty(this DataRequirement.SortComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          current.PathElement = new FhirString(reader.GetString());

          break;

        case "direction":
          current.DirectionElement =new Code<Hl7.Fhir.Model.DataRequirement.SortDirection>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DataRequirement.SortDirection>(reader.GetString()));

          break;

      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class DataRequirementJsonConverter : JsonConverter<DataRequirement>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(DataRequirement).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, DataRequirement value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override DataRequirement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        DataRequirement target = new DataRequirement();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
