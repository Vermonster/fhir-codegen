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
  /// JSON Serialization Extensions for PractitionerRole
  /// </summary>
  public static class PractitionerRoleJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR PractitionerRole into JSON
    /// </summary>
    public static void SerializeJson(this PractitionerRole current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","PractitionerRole");
      // Complex: PractitionerRole, Export: PractitionerRole, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ActiveElement != null) && (current.ActiveElement.Value != null))
      {
        writer.WriteBoolean("active",(bool)current.ActiveElement.Value);
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if (current.Practitioner != null)
      {
        writer.WritePropertyName("practitioner");
        current.Practitioner.SerializeJson(writer, options);
      }

      if (current.Organization != null)
      {
        writer.WritePropertyName("organization");
        current.Organization.SerializeJson(writer, options);
      }

      if ((current.Code != null) && (current.Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Code)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Specialty != null) && (current.Specialty.Count != 0))
      {
        writer.WritePropertyName("specialty");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Specialty)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Location != null) && (current.Location.Count != 0))
      {
        writer.WritePropertyName("location");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Location)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.HealthcareService != null) && (current.HealthcareService.Count != 0))
      {
        writer.WritePropertyName("healthcareService");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.HealthcareService)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Telecom != null) && (current.Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();
        foreach (ContactPoint val in current.Telecom)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.AvailableTime != null) && (current.AvailableTime.Count != 0))
      {
        writer.WritePropertyName("availableTime");
        writer.WriteStartArray();
        foreach (PractitionerRole.AvailableTimeComponent val in current.AvailableTime)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.NotAvailable != null) && (current.NotAvailable.Count != 0))
      {
        writer.WritePropertyName("notAvailable");
        writer.WriteStartArray();
        foreach (PractitionerRole.NotAvailableComponent val in current.NotAvailable)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.AvailabilityExceptionsElement != null) && (current.AvailabilityExceptionsElement.Value != null))
      {
        writer.WriteString("availabilityExceptions",current.AvailabilityExceptionsElement.Value);
      }

      if ((current.Endpoint != null) && (current.Endpoint.Count != 0))
      {
        writer.WritePropertyName("endpoint");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Endpoint)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole
    /// </summary>
    public static void DeserializeJson(this PractitionerRole current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR PractitionerRole
    /// </summary>
    public static void DeserializeJsonProperty(this PractitionerRole current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Identifier.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }

          break;

        case "active":
          current.ActiveElement = new FhirBoolean(reader.GetBoolean());

          break;

        case "period":
          current.Period = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);

          break;

        case "practitioner":
          current.Practitioner = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "organization":
          current.Organization = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Code.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

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

        case "specialty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Specialty = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Specialty.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Specialty.Count == 0)
          {
            current.Specialty = null;
          }

          break;

        case "location":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Location = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Location.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Location.Count == 0)
          {
            current.Location = null;
          }

          break;

        case "healthcareService":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.HealthcareService = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.HealthcareService.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.HealthcareService.Count == 0)
          {
            current.HealthcareService = null;
          }

          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Telecom.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactPoint>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Telecom.Count == 0)
          {
            current.Telecom = null;
          }

          break;

        case "availableTime":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.AvailableTime = new List<PractitionerRole.AvailableTimeComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.AvailableTime.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.AvailableTime.Count == 0)
          {
            current.AvailableTime = null;
          }

          break;

        case "notAvailable":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.NotAvailable = new List<PractitionerRole.NotAvailableComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.NotAvailable.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.PractitionerRole.NotAvailableComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.NotAvailable.Count == 0)
          {
            current.NotAvailable = null;
          }

          break;

        case "availabilityExceptions":
          current.AvailabilityExceptionsElement = new FhirString(reader.GetString());

          break;

        case "endpoint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Endpoint = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Endpoint.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Endpoint.Count == 0)
          {
            current.Endpoint = null;
          }

          break;

        // Complex: PractitionerRole, Export: PractitionerRole, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR PractitionerRole#AvailableTime into JSON
    /// </summary>
    public static void SerializeJson(this PractitionerRole.AvailableTimeComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: PractitionerRole#AvailableTime, Export: AvailableTimeComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.DaysOfWeekElement != null) && (current.DaysOfWeekElement.Count != 0))
      {
        writer.WritePropertyName("daysOfWeek");
        writer.WriteStartArray();
        foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
        {
          writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
        }
        writer.WriteEndArray();
      }

      if ((current.AllDayElement != null) && (current.AllDayElement.Value != null))
      {
        writer.WriteBoolean("allDay",(bool)current.AllDayElement.Value);
      }

      if (current.AvailableStartTimeElement != null)
      {
        writer.WritePropertyName("availableStartTime");
        current.AvailableStartTimeElement.SerializeJson(writer, options);
      }

      if (current.AvailableEndTimeElement != null)
      {
        writer.WritePropertyName("availableEndTime");
        current.AvailableEndTimeElement.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole#AvailableTime
    /// </summary>
    public static void DeserializeJson(this PractitionerRole.AvailableTimeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR PractitionerRole#AvailableTime
    /// </summary>
    public static void DeserializeJsonProperty(this PractitionerRole.AvailableTimeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DaysOfWeekElement = new List<Code<Hl7.Fhir.Model.DaysOfWeek>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DaysOfWeek>(reader.GetString())));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.DaysOfWeekElement.Count == 0)
          {
            current.DaysOfWeekElement = null;
          }

          break;

        case "allDay":
          current.AllDayElement = new FhirBoolean(reader.GetBoolean());

          break;

        case "availableStartTime":
          current.AvailableStartTimeElement = JsonSerializer.Deserialize<Hl7.Fhir.Model.Time>(ref reader, options);

          break;

        case "availableEndTime":
          current.AvailableEndTimeElement = JsonSerializer.Deserialize<Hl7.Fhir.Model.Time>(ref reader, options);

          break;

        // Complex: availableTime, Export: AvailableTimeComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR PractitionerRole#NotAvailable into JSON
    /// </summary>
    public static void SerializeJson(this PractitionerRole.NotAvailableComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: PractitionerRole#NotAvailable, Export: NotAvailableComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("description",current.DescriptionElement.Value);

      if (current.During != null)
      {
        writer.WritePropertyName("during");
        current.During.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole#NotAvailable
    /// </summary>
    public static void DeserializeJson(this PractitionerRole.NotAvailableComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR PractitionerRole#NotAvailable
    /// </summary>
    public static void DeserializeJsonProperty(this PractitionerRole.NotAvailableComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());

          break;

        case "during":
          current.During = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);

          break;

        // Complex: notAvailable, Export: NotAvailableComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class PractitionerRoleJsonConverter : JsonConverter<PractitionerRole>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(PractitionerRole).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, PractitionerRole value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override PractitionerRole Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        PractitionerRole target = new PractitionerRole();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
