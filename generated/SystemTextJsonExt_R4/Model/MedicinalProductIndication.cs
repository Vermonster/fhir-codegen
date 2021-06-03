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
  /// JSON Serialization Extensions for MedicinalProductIndication
  /// </summary>
  public static class MedicinalProductIndicationJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicinalProductIndication into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIndication current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicinalProductIndication");
      // Complex: MedicinalProductIndication, Export: MedicinalProductIndication, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Subject != null) && (current.Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Subject)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.DiseaseSymptomProcedure != null)
      {
        writer.WritePropertyName("diseaseSymptomProcedure");
        current.DiseaseSymptomProcedure.SerializeJson(writer, options);
      }

      if (current.DiseaseStatus != null)
      {
        writer.WritePropertyName("diseaseStatus");
        current.DiseaseStatus.SerializeJson(writer, options);
      }

      if ((current.Comorbidity != null) && (current.Comorbidity.Count != 0))
      {
        writer.WritePropertyName("comorbidity");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Comorbidity)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.IntendedEffect != null)
      {
        writer.WritePropertyName("intendedEffect");
        current.IntendedEffect.SerializeJson(writer, options);
      }

      if (current.Duration != null)
      {
        writer.WritePropertyName("duration");
        current.Duration.SerializeJson(writer, options);
      }

      if ((current.OtherTherapy != null) && (current.OtherTherapy.Count != 0))
      {
        writer.WritePropertyName("otherTherapy");
        writer.WriteStartArray();
        foreach (MedicinalProductIndication.OtherTherapyComponent val in current.OtherTherapy)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.UndesirableEffect != null) && (current.UndesirableEffect.Count != 0))
      {
        writer.WritePropertyName("undesirableEffect");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.UndesirableEffect)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Population != null) && (current.Population.Count != 0))
      {
        writer.WritePropertyName("population");
        writer.WriteStartArray();
        foreach (Population val in current.Population)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIndication
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIndication current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductIndication >>> MedicinalProductIndication.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductIndication: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIndication
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIndication current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductIndication error reading 'subject' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Subject = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Subject = new Hl7.Fhir.Model.ResourceReference();
            v_Subject.DeserializeJson(ref reader, options);
            current.Subject.Add(v_Subject);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductIndication error reading 'subject' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Subject.Count == 0)
          {
            current.Subject = null;
          }
          break;

        case "diseaseSymptomProcedure":
          current.DiseaseSymptomProcedure = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.DiseaseSymptomProcedure).DeserializeJson(ref reader, options);
          break;

        case "diseaseStatus":
          current.DiseaseStatus = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.DiseaseStatus).DeserializeJson(ref reader, options);
          break;

        case "comorbidity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductIndication error reading 'comorbidity' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Comorbidity = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Comorbidity = new Hl7.Fhir.Model.CodeableConcept();
            v_Comorbidity.DeserializeJson(ref reader, options);
            current.Comorbidity.Add(v_Comorbidity);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductIndication error reading 'comorbidity' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Comorbidity.Count == 0)
          {
            current.Comorbidity = null;
          }
          break;

        case "intendedEffect":
          current.IntendedEffect = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.IntendedEffect).DeserializeJson(ref reader, options);
          break;

        case "duration":
          current.Duration = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Duration).DeserializeJson(ref reader, options);
          break;

        case "otherTherapy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductIndication error reading 'otherTherapy' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.OtherTherapy = new List<MedicinalProductIndication.OtherTherapyComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent v_OtherTherapy = new Hl7.Fhir.Model.MedicinalProductIndication.OtherTherapyComponent();
            v_OtherTherapy.DeserializeJson(ref reader, options);
            current.OtherTherapy.Add(v_OtherTherapy);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductIndication error reading 'otherTherapy' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.OtherTherapy.Count == 0)
          {
            current.OtherTherapy = null;
          }
          break;

        case "undesirableEffect":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductIndication error reading 'undesirableEffect' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.UndesirableEffect = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_UndesirableEffect = new Hl7.Fhir.Model.ResourceReference();
            v_UndesirableEffect.DeserializeJson(ref reader, options);
            current.UndesirableEffect.Add(v_UndesirableEffect);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductIndication error reading 'undesirableEffect' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.UndesirableEffect.Count == 0)
          {
            current.UndesirableEffect = null;
          }
          break;

        case "population":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductIndication error reading 'population' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Population = new List<Population>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Population v_Population = new Hl7.Fhir.Model.Population();
            v_Population.DeserializeJson(ref reader, options);
            current.Population.Add(v_Population);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductIndication error reading 'population' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Population.Count == 0)
          {
            current.Population = null;
          }
          break;

        // Complex: MedicinalProductIndication, Export: MedicinalProductIndication, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductIndication#OtherTherapy into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductIndication.OtherTherapyComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductIndication#OtherTherapy, Export: OtherTherapyComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("therapyRelationshipType");
      current.TherapyRelationshipType.SerializeJson(writer, options);

      if (current.Medication != null)
      {
        switch (current.Medication)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("medicationCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("medicationReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIndication#OtherTherapy
    /// </summary>
    public static void DeserializeJson(this MedicinalProductIndication.OtherTherapyComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductIndication.OtherTherapyComponent >>> MedicinalProductIndication#OtherTherapy.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductIndication.OtherTherapyComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductIndication#OtherTherapy
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductIndication.OtherTherapyComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "therapyRelationshipType":
          current.TherapyRelationshipType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.TherapyRelationshipType).DeserializeJson(ref reader, options);
          break;

        case "medicationCodeableConcept":
          current.Medication = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Medication).DeserializeJson(ref reader, options);
          break;

        case "medicationReference":
          current.Medication = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Medication).DeserializeJson(ref reader, options);
          break;

        // Complex: otherTherapy, Export: OtherTherapyComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicinalProductIndicationJsonConverter : JsonConverter<MedicinalProductIndication>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MedicinalProductIndication value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MedicinalProductIndication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MedicinalProductIndication target = new MedicinalProductIndication();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
