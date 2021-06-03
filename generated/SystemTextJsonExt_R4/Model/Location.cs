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
  /// JSON Serialization Extensions for Location
  /// </summary>
  public static class LocationJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Location into JSON
    /// </summary>
    public static void SerializeJson(this Location current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Location");
      // Complex: Location, Export: Location, Base: DomainResource (DomainResource)
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

      if (current.StatusElement != null)
      {
        if (current.StatusElement.Value != null)
        {
          writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));
        }
        if (current.StatusElement.HasExtensions() || (!string.IsNullOrEmpty(current.StatusElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_status",false,current.StatusElement.Extension,current.StatusElement.ElementId);
        }
      }

      if (current.OperationalStatus != null)
      {
        writer.WritePropertyName("operationalStatus");
        current.OperationalStatus.SerializeJson(writer, options);
      }

      if (current.NameElement != null)
      {
        if (!string.IsNullOrEmpty(current.NameElement.Value))
        {
          writer.WriteString("name",current.NameElement.Value);
        }
        if (current.NameElement.HasExtensions() || (!string.IsNullOrEmpty(current.NameElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_name",false,current.NameElement.Extension,current.NameElement.ElementId);
        }
      }

      if ((current.AliasElement != null) && (current.AliasElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (FhirString val in current.AliasElement)
        {
          if (!string.IsNullOrEmpty(val.Value)) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("alias");
          writer.WriteStartArray();
          foreach (FhirString val in current.AliasElement)
          {
            if (string.IsNullOrEmpty(val.Value))
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(val.Value);
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_alias");
          writer.WriteStartArray();
          foreach (FhirString val in current.AliasElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if (current.DescriptionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DescriptionElement.Value))
        {
          writer.WriteString("description",current.DescriptionElement.Value);
        }
        if (current.DescriptionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DescriptionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_description",false,current.DescriptionElement.Extension,current.DescriptionElement.ElementId);
        }
      }

      if (current.ModeElement != null)
      {
        if (current.ModeElement.Value != null)
        {
          writer.WriteString("mode",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ModeElement.Value));
        }
        if (current.ModeElement.HasExtensions() || (!string.IsNullOrEmpty(current.ModeElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_mode",false,current.ModeElement.Extension,current.ModeElement.ElementId);
        }
      }

      if ((current.Type != null) && (current.Type.Count != 0))
      {
        writer.WritePropertyName("type");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Type)
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

      if (current.Address != null)
      {
        writer.WritePropertyName("address");
        current.Address.SerializeJson(writer, options);
      }

      if (current.PhysicalType != null)
      {
        writer.WritePropertyName("physicalType");
        current.PhysicalType.SerializeJson(writer, options);
      }

      if (current.Position != null)
      {
        writer.WritePropertyName("position");
        current.Position.SerializeJson(writer, options);
      }

      if (current.ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        current.ManagingOrganization.SerializeJson(writer, options);
      }

      if (current.PartOf != null)
      {
        writer.WritePropertyName("partOf");
        current.PartOf.SerializeJson(writer, options);
      }

      if ((current.HoursOfOperation != null) && (current.HoursOfOperation.Count != 0))
      {
        writer.WritePropertyName("hoursOfOperation");
        writer.WriteStartArray();
        foreach (Location.HoursOfOperationComponent val in current.HoursOfOperation)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.AvailabilityExceptionsElement != null)
      {
        if (!string.IsNullOrEmpty(current.AvailabilityExceptionsElement.Value))
        {
          writer.WriteString("availabilityExceptions",current.AvailabilityExceptionsElement.Value);
        }
        if (current.AvailabilityExceptionsElement.HasExtensions() || (!string.IsNullOrEmpty(current.AvailabilityExceptionsElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_availabilityExceptions",false,current.AvailabilityExceptionsElement.Extension,current.AvailabilityExceptionsElement.ElementId);
        }
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
    /// Deserialize JSON into a FHIR Location
    /// </summary>
    public static void DeserializeJson(this Location current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Location >>> Location.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Location: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Location
    /// </summary>
    public static void DeserializeJsonProperty(this Location current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Location.LocationStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Location.LocationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Location.LocationStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Location.LocationStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "operationalStatus":
          current.OperationalStatus = new Hl7.Fhir.Model.Coding();
          ((Hl7.Fhir.Model.Coding)current.OperationalStatus).DeserializeJson(ref reader, options);
          break;

        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "alias":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'alias' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.AliasElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.AliasElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.AliasElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'alias' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.AliasElement.Count == 0)
          {
            current.AliasElement = null;
          }
          break;

        case "_alias":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'alias' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_alias = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_alias >= current.AliasElement.Count)
            {
              current.AliasElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.AliasElement[i_alias++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'alias' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "mode":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ModeElement = new Code<Hl7.Fhir.Model.Location.LocationMode>();
            reader.Skip();
          }
          else
          {
            current.ModeElement = new Code<Hl7.Fhir.Model.Location.LocationMode>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Location.LocationMode>(reader.GetString()));
          }
          break;

        case "_mode":
          if (current.ModeElement == null) { current.ModeElement = new Code<Hl7.Fhir.Model.Location.LocationMode>(); }
          ((Hl7.Fhir.Model.Element)current.ModeElement).DeserializeJson(ref reader, options);
          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'type' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Type = new Hl7.Fhir.Model.CodeableConcept();
            v_Type.DeserializeJson(ref reader, options);
            current.Type.Add(v_Type);

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'type' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Type.Count == 0)
          {
            current.Type = null;
          }
          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'telecom' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactPoint v_Telecom = new Hl7.Fhir.Model.ContactPoint();
            v_Telecom.DeserializeJson(ref reader, options);
            current.Telecom.Add(v_Telecom);

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'telecom' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Telecom.Count == 0)
          {
            current.Telecom = null;
          }
          break;

        case "address":
          current.Address = new Hl7.Fhir.Model.Address();
          ((Hl7.Fhir.Model.Address)current.Address).DeserializeJson(ref reader, options);
          break;

        case "physicalType":
          current.PhysicalType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.PhysicalType).DeserializeJson(ref reader, options);
          break;

        case "position":
          current.Position = new Hl7.Fhir.Model.Location.PositionComponent();
          ((Hl7.Fhir.Model.Location.PositionComponent)current.Position).DeserializeJson(ref reader, options);
          break;

        case "managingOrganization":
          current.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.ManagingOrganization).DeserializeJson(ref reader, options);
          break;

        case "partOf":
          current.PartOf = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.PartOf).DeserializeJson(ref reader, options);
          break;

        case "hoursOfOperation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'hoursOfOperation' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.HoursOfOperation = new List<Location.HoursOfOperationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Location.HoursOfOperationComponent v_HoursOfOperation = new Hl7.Fhir.Model.Location.HoursOfOperationComponent();
            v_HoursOfOperation.DeserializeJson(ref reader, options);
            current.HoursOfOperation.Add(v_HoursOfOperation);

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'hoursOfOperation' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.HoursOfOperation.Count == 0)
          {
            current.HoursOfOperation = null;
          }
          break;

        case "availabilityExceptions":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AvailabilityExceptionsElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.AvailabilityExceptionsElement = new FhirString(reader.GetString());
          }
          break;

        case "_availabilityExceptions":
          if (current.AvailabilityExceptionsElement == null) { current.AvailabilityExceptionsElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.AvailabilityExceptionsElement).DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Location error reading 'endpoint' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Endpoint = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Endpoint = new Hl7.Fhir.Model.ResourceReference();
            v_Endpoint.DeserializeJson(ref reader, options);
            current.Endpoint.Add(v_Endpoint);

            if (!reader.Read())
            {
              throw new JsonException($"Location error reading 'endpoint' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Endpoint.Count == 0)
          {
            current.Endpoint = null;
          }
          break;

        // Complex: Location, Export: Location, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Location#Position into JSON
    /// </summary>
    public static void SerializeJson(this Location.PositionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Location#Position, Export: PositionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteNumber("longitude",(decimal)current.LongitudeElement.Value);

      writer.WriteNumber("latitude",(decimal)current.LatitudeElement.Value);

      if (current.AltitudeElement != null)
      {
        if (current.AltitudeElement.Value != null)
        {
          writer.WriteNumber("altitude",(decimal)current.AltitudeElement.Value);
        }
        if (current.AltitudeElement.HasExtensions() || (!string.IsNullOrEmpty(current.AltitudeElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_altitude",false,current.AltitudeElement.Extension,current.AltitudeElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Location#Position
    /// </summary>
    public static void DeserializeJson(this Location.PositionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Location.PositionComponent >>> Location#Position.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Location.PositionComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Location#Position
    /// </summary>
    public static void DeserializeJsonProperty(this Location.PositionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "longitude":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.LongitudeElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.LongitudeElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_longitude":
          if (current.LongitudeElement == null) { current.LongitudeElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.LongitudeElement).DeserializeJson(ref reader, options);
          break;

        case "latitude":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.LatitudeElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.LatitudeElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_latitude":
          if (current.LatitudeElement == null) { current.LatitudeElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.LatitudeElement).DeserializeJson(ref reader, options);
          break;

        case "altitude":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AltitudeElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.AltitudeElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_altitude":
          if (current.AltitudeElement == null) { current.AltitudeElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.AltitudeElement).DeserializeJson(ref reader, options);
          break;

        // Complex: position, Export: PositionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Location#HoursOfOperation into JSON
    /// </summary>
    public static void SerializeJson(this Location.HoursOfOperationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Location#HoursOfOperation, Export: HoursOfOperationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.DaysOfWeekElement != null) && (current.DaysOfWeekElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
        {
          if (val.Value != null) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("daysOfWeek");
          writer.WriteStartArray();
          foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
          {
            if (val.Value == null)
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_daysOfWeek");
          writer.WriteStartArray();
          foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if (current.AllDayElement != null)
      {
        if (current.AllDayElement.Value != null)
        {
          writer.WriteBoolean("allDay",(bool)current.AllDayElement.Value);
        }
        if (current.AllDayElement.HasExtensions() || (!string.IsNullOrEmpty(current.AllDayElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_allDay",false,current.AllDayElement.Extension,current.AllDayElement.ElementId);
        }
      }

      if (current.OpeningTimeElement != null)
      {
        writer.WritePropertyName("openingTime");
        current.OpeningTimeElement.SerializeJson(writer, options);
      }

      if (current.ClosingTimeElement != null)
      {
        writer.WritePropertyName("closingTime");
        current.ClosingTimeElement.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Location#HoursOfOperation
    /// </summary>
    public static void DeserializeJson(this Location.HoursOfOperationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Location.HoursOfOperationComponent >>> Location#HoursOfOperation.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Location.HoursOfOperationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Location#HoursOfOperation
    /// </summary>
    public static void DeserializeJsonProperty(this Location.HoursOfOperationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"HoursOfOperationComponent error reading 'daysOfWeek' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DaysOfWeekElement = new List<Code<Hl7.Fhir.Model.DaysOfWeek>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>());
              reader.Skip();
            }
            else
            {
              current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DaysOfWeek>(reader.GetString())));
            }

            if (!reader.Read())
            {
              throw new JsonException($"HoursOfOperationComponent error reading 'daysOfWeek' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DaysOfWeekElement.Count == 0)
          {
            current.DaysOfWeekElement = null;
          }
          break;

        case "_daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"HoursOfOperationComponent error reading 'daysOfWeek' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_daysOfWeek = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_daysOfWeek >= current.DaysOfWeekElement.Count)
            {
              current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.DaysOfWeekElement[i_daysOfWeek++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"HoursOfOperationComponent error reading 'daysOfWeek' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "allDay":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AllDayElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.AllDayElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_allDay":
          if (current.AllDayElement == null) { current.AllDayElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.AllDayElement).DeserializeJson(ref reader, options);
          break;

        case "openingTime":
          current.OpeningTimeElement = new Hl7.Fhir.Model.Time();
          ((Hl7.Fhir.Model.Time)current.OpeningTimeElement).DeserializeJson(ref reader, options);
          break;

        case "closingTime":
          current.ClosingTimeElement = new Hl7.Fhir.Model.Time();
          ((Hl7.Fhir.Model.Time)current.ClosingTimeElement).DeserializeJson(ref reader, options);
          break;

        // Complex: hoursOfOperation, Export: HoursOfOperationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class LocationJsonConverter : JsonConverter<Location>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Location value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Location Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Location target = new Location();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
