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
  /// JSON Serialization Extensions for MedicinalProductIngredient
  /// </summary>
  public static class MedicinalProductIngredientJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicinalProductIngredient into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIngredient current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicinalProductIngredient");
      // Complex: MedicinalProductIngredient, Export: MedicinalProductIngredient, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.Identifier != null)
      {
        writer.WritePropertyName("identifier");
        current.Identifier.SerializeJson(writer, options);
      }

      writer.WritePropertyName("role");
      current.Role.SerializeJson(writer, options);

      if ((current.AllergenicIndicatorElement != null) && (current.AllergenicIndicatorElement.Value != null))
      {
        writer.WriteBoolean("allergenicIndicator",(bool)current.AllergenicIndicatorElement.Value);
      }

      if ((current.Manufacturer != null) && (current.Manufacturer.Count != 0))
      {
        writer.WritePropertyName("manufacturer");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Manufacturer)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.SpecifiedSubstance != null) && (current.SpecifiedSubstance.Count != 0))
      {
        writer.WritePropertyName("specifiedSubstance");
        writer.WriteStartArray();
        foreach (MedicinalProductIngredient.SpecifiedSubstanceComponent val in current.SpecifiedSubstance)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Substance != null)
      {
        writer.WritePropertyName("substance");
        current.Substance.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIngredient
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIngredient current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MedicinalProductIngredient
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIngredient current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          current.Identifier = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);

          break;

        case "role":
          current.Role = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "allergenicIndicator":
          current.AllergenicIndicatorElement = new FhirBoolean(reader.GetBoolean());

          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Manufacturer = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Manufacturer.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Manufacturer.Count == 0)
          {
            current.Manufacturer = null;
          }

          break;

        case "specifiedSubstance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.SpecifiedSubstance.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.MedicinalProductIngredient.SpecifiedSubstanceComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.SpecifiedSubstance.Count == 0)
          {
            current.SpecifiedSubstance = null;
          }

          break;

        case "substance":
          current.Substance = JsonSerializer.Deserialize<Hl7.Fhir.Model.MedicinalProductIngredient.SubstanceComponent>(ref reader, options);

          break;

        // Complex: MedicinalProductIngredient, Export: MedicinalProductIngredient, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductIngredient#SpecifiedSubstance into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIngredient.SpecifiedSubstanceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductIngredient#SpecifiedSubstance, Export: SpecifiedSubstanceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("code");
      current.Code.SerializeJson(writer, options);

      writer.WritePropertyName("group");
      current.Group.SerializeJson(writer, options);

      if (current.Confidentiality != null)
      {
        writer.WritePropertyName("confidentiality");
        current.Confidentiality.SerializeJson(writer, options);
      }

      if ((current.Strength != null) && (current.Strength.Count != 0))
      {
        writer.WritePropertyName("strength");
        writer.WriteStartArray();
        foreach (MedicinalProductIngredient.StrengthComponent val in current.Strength)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#SpecifiedSubstance
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIngredient.SpecifiedSubstanceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#SpecifiedSubstance
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIngredient.SpecifiedSubstanceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "group":
          current.Group = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "confidentiality":
          current.Confidentiality = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "strength":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Strength = new List<MedicinalProductIngredient.StrengthComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Strength.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.MedicinalProductIngredient.StrengthComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Strength.Count == 0)
          {
            current.Strength = null;
          }

          break;

        // Complex: specifiedSubstance, Export: SpecifiedSubstanceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductIngredient#Strength into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIngredient.StrengthComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductIngredient#Strength, Export: StrengthComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("presentation");
      current.Presentation.SerializeJson(writer, options);

      if (current.PresentationLowLimit != null)
      {
        writer.WritePropertyName("presentationLowLimit");
        current.PresentationLowLimit.SerializeJson(writer, options);
      }

      if (current.Concentration != null)
      {
        writer.WritePropertyName("concentration");
        current.Concentration.SerializeJson(writer, options);
      }

      if (current.ConcentrationLowLimit != null)
      {
        writer.WritePropertyName("concentrationLowLimit");
        current.ConcentrationLowLimit.SerializeJson(writer, options);
      }

      if ((current.MeasurementPointElement != null) && (current.MeasurementPointElement.Value != null))
      {
        writer.WriteString("measurementPoint",current.MeasurementPointElement.Value);
      }

      if ((current.Country != null) && (current.Country.Count != 0))
      {
        writer.WritePropertyName("country");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Country)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReferenceStrength != null) && (current.ReferenceStrength.Count != 0))
      {
        writer.WritePropertyName("referenceStrength");
        writer.WriteStartArray();
        foreach (MedicinalProductIngredient.ReferenceStrengthComponent val in current.ReferenceStrength)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#Strength
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIngredient.StrengthComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#Strength
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIngredient.StrengthComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "presentation":
          current.Presentation = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "presentationLowLimit":
          current.PresentationLowLimit = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "concentration":
          current.Concentration = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "concentrationLowLimit":
          current.ConcentrationLowLimit = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "measurementPoint":
          current.MeasurementPointElement = new FhirString(reader.GetString());

          break;

        case "country":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Country = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Country.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Country.Count == 0)
          {
            current.Country = null;
          }

          break;

        case "referenceStrength":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReferenceStrength = new List<MedicinalProductIngredient.ReferenceStrengthComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReferenceStrength.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.MedicinalProductIngredient.ReferenceStrengthComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ReferenceStrength.Count == 0)
          {
            current.ReferenceStrength = null;
          }

          break;

        // Complex: strength, Export: StrengthComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductIngredient#ReferenceStrength into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIngredient.ReferenceStrengthComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductIngredient#ReferenceStrength, Export: ReferenceStrengthComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Substance != null)
      {
        writer.WritePropertyName("substance");
        current.Substance.SerializeJson(writer, options);
      }

      writer.WritePropertyName("strength");
      current.Strength.SerializeJson(writer, options);

      if (current.StrengthLowLimit != null)
      {
        writer.WritePropertyName("strengthLowLimit");
        current.StrengthLowLimit.SerializeJson(writer, options);
      }

      if ((current.MeasurementPointElement != null) && (current.MeasurementPointElement.Value != null))
      {
        writer.WriteString("measurementPoint",current.MeasurementPointElement.Value);
      }

      if ((current.Country != null) && (current.Country.Count != 0))
      {
        writer.WritePropertyName("country");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Country)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#ReferenceStrength
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIngredient.ReferenceStrengthComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#ReferenceStrength
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIngredient.ReferenceStrengthComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "substance":
          current.Substance = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "strength":
          current.Strength = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "strengthLowLimit":
          current.StrengthLowLimit = JsonSerializer.Deserialize<Hl7.Fhir.Model.Ratio>(ref reader, options);

          break;

        case "measurementPoint":
          current.MeasurementPointElement = new FhirString(reader.GetString());

          break;

        case "country":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Country = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Country.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Country.Count == 0)
          {
            current.Country = null;
          }

          break;

        // Complex: referenceStrength, Export: ReferenceStrengthComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductIngredient#Substance into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIngredient.SubstanceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductIngredient#Substance, Export: SubstanceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("code");
      current.Code.SerializeJson(writer, options);

      if ((current.Strength != null) && (current.Strength.Count != 0))
      {
        writer.WritePropertyName("strength");
        writer.WriteStartArray();
        foreach (MedicinalProductIngredient.StrengthComponent val in current.Strength)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#Substance
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIngredient.SubstanceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MedicinalProductIngredient#Substance
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIngredient.SubstanceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "strength":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Strength = new List<MedicinalProductIngredient.StrengthComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Strength.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.MedicinalProductIngredient.StrengthComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Strength.Count == 0)
          {
            current.Strength = null;
          }

          break;

        // Complex: substance, Export: SubstanceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicinalProductIngredientJsonConverter : JsonConverter<MedicinalProductIngredient>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(MedicinalProductIngredient).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MedicinalProductIngredient value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MedicinalProductIngredient Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MedicinalProductIngredient target = new MedicinalProductIngredient();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
