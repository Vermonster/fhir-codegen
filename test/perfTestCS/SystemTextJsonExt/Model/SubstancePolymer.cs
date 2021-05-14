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
  /// JSON Serialization Extensions for SubstancePolymer
  /// </summary>
  public static class SubstancePolymerJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR SubstancePolymer into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","SubstancePolymer");
      // Complex: SubstancePolymer, Export: SubstancePolymer, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.Class != null)
      {
        writer.WritePropertyName("class");
        current.Class.SerializeJson(writer, options);
      }

      if (current.Geometry != null)
      {
        writer.WritePropertyName("geometry");
        current.Geometry.SerializeJson(writer, options);
      }

      if ((current.CopolymerConnectivity != null) && (current.CopolymerConnectivity.Count != 0))
      {
        writer.WritePropertyName("copolymerConnectivity");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.CopolymerConnectivity)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ModificationElement != null) && (current.ModificationElement.Count != 0))
      {
        writer.WritePropertyName("modification");
        writer.WriteStartArray();
        foreach (FhirString val in current.ModificationElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.MonomerSet != null) && (current.MonomerSet.Count != 0))
      {
        writer.WritePropertyName("monomerSet");
        writer.WriteStartArray();
        foreach (SubstancePolymer.MonomerSetComponent val in current.MonomerSet)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Repeat != null) && (current.Repeat.Count != 0))
      {
        writer.WritePropertyName("repeat");
        writer.WriteStartArray();
        foreach (SubstancePolymer.RepeatComponent val in current.Repeat)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "class":
          current.Class = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "geometry":
          current.Geometry = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "copolymerConnectivity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.CopolymerConnectivity = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.CopolymerConnectivity.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.CopolymerConnectivity.Count == 0)
          {
            current.CopolymerConnectivity = null;
          }

          break;

        case "modification":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ModificationElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ModificationElement.Add(new FhirString(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ModificationElement.Count == 0)
          {
            current.ModificationElement = null;
          }

          break;

        case "monomerSet":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.MonomerSet = new List<SubstancePolymer.MonomerSetComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.MonomerSet.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstancePolymer.MonomerSetComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.MonomerSet.Count == 0)
          {
            current.MonomerSet = null;
          }

          break;

        case "repeat":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Repeat = new List<SubstancePolymer.RepeatComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Repeat.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstancePolymer.RepeatComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Repeat.Count == 0)
          {
            current.Repeat = null;
          }

          break;

        // Complex: SubstancePolymer, Export: SubstancePolymer, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstancePolymer#MonomerSet into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer.MonomerSetComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstancePolymer#MonomerSet, Export: MonomerSetComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.RatioType != null)
      {
        writer.WritePropertyName("ratioType");
        current.RatioType.SerializeJson(writer, options);
      }

      if ((current.StartingMaterial != null) && (current.StartingMaterial.Count != 0))
      {
        writer.WritePropertyName("startingMaterial");
        writer.WriteStartArray();
        foreach (SubstancePolymer.StartingMaterialComponent val in current.StartingMaterial)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer#MonomerSet
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer.MonomerSetComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer#MonomerSet
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer.MonomerSetComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "ratioType":
          current.RatioType = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "startingMaterial":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.StartingMaterial = new List<SubstancePolymer.StartingMaterialComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.StartingMaterial.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstancePolymer.StartingMaterialComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.StartingMaterial.Count == 0)
          {
            current.StartingMaterial = null;
          }

          break;

        // Complex: monomerSet, Export: MonomerSetComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstancePolymer#StartingMaterial into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer.StartingMaterialComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstancePolymer#StartingMaterial, Export: StartingMaterialComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Material != null)
      {
        writer.WritePropertyName("material");
        current.Material.SerializeJson(writer, options);
      }

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if ((current.IsDefiningElement != null) && (current.IsDefiningElement.Value != null))
      {
        writer.WriteBoolean("isDefining",(bool)current.IsDefiningElement.Value);
      }

      if (current.Amount != null)
      {
        writer.WritePropertyName("amount");
        current.Amount.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer#StartingMaterial
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer.StartingMaterialComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer#StartingMaterial
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer.StartingMaterialComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "material":
          current.Material = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "type":
          current.Type = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "isDefining":
          current.IsDefiningElement = new FhirBoolean(reader.GetBoolean());

          break;

        case "amount":
          current.Amount = JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstanceAmount>(ref reader, options);

          break;

        // Complex: startingMaterial, Export: StartingMaterialComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstancePolymer#Repeat into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer.RepeatComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstancePolymer#Repeat, Export: RepeatComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.NumberOfUnitsElement != null) && (current.NumberOfUnitsElement.Value != null))
      {
        writer.WriteNumber("numberOfUnits",(int)current.NumberOfUnitsElement.Value);
      }

      if ((current.AverageMolecularFormulaElement != null) && (current.AverageMolecularFormulaElement.Value != null))
      {
        writer.WriteString("averageMolecularFormula",current.AverageMolecularFormulaElement.Value);
      }

      if (current.RepeatUnitAmountType != null)
      {
        writer.WritePropertyName("repeatUnitAmountType");
        current.RepeatUnitAmountType.SerializeJson(writer, options);
      }

      if ((current.RepeatUnit != null) && (current.RepeatUnit.Count != 0))
      {
        writer.WritePropertyName("repeatUnit");
        writer.WriteStartArray();
        foreach (SubstancePolymer.RepeatUnitComponent val in current.RepeatUnit)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer#Repeat
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer.RepeatComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer#Repeat
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer.RepeatComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "numberOfUnits":
          current.NumberOfUnitsElement = new Integer(reader.GetInt32());

          break;

        case "averageMolecularFormula":
          current.AverageMolecularFormulaElement = new FhirString(reader.GetString());

          break;

        case "repeatUnitAmountType":
          current.RepeatUnitAmountType = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "repeatUnit":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.RepeatUnit = new List<SubstancePolymer.RepeatUnitComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.RepeatUnit.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.RepeatUnit.Count == 0)
          {
            current.RepeatUnit = null;
          }

          break;

        // Complex: repeat, Export: RepeatComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstancePolymer#RepeatUnit into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer.RepeatUnitComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstancePolymer#RepeatUnit, Export: RepeatUnitComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.OrientationOfPolymerisation != null)
      {
        writer.WritePropertyName("orientationOfPolymerisation");
        current.OrientationOfPolymerisation.SerializeJson(writer, options);
      }

      if ((current.RepeatUnitElement != null) && (current.RepeatUnitElement.Value != null))
      {
        writer.WriteString("repeatUnit",current.RepeatUnitElement.Value);
      }

      if (current.Amount != null)
      {
        writer.WritePropertyName("amount");
        current.Amount.SerializeJson(writer, options);
      }

      if ((current.DegreeOfPolymerisation != null) && (current.DegreeOfPolymerisation.Count != 0))
      {
        writer.WritePropertyName("degreeOfPolymerisation");
        writer.WriteStartArray();
        foreach (SubstancePolymer.DegreeOfPolymerisationComponent val in current.DegreeOfPolymerisation)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.StructuralRepresentation != null) && (current.StructuralRepresentation.Count != 0))
      {
        writer.WritePropertyName("structuralRepresentation");
        writer.WriteStartArray();
        foreach (SubstancePolymer.StructuralRepresentationComponent val in current.StructuralRepresentation)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer#RepeatUnit
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer.RepeatUnitComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer#RepeatUnit
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer.RepeatUnitComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "orientationOfPolymerisation":
          current.OrientationOfPolymerisation = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "repeatUnit":
          current.RepeatUnitElement = new FhirString(reader.GetString());

          break;

        case "amount":
          current.Amount = JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstanceAmount>(ref reader, options);

          break;

        case "degreeOfPolymerisation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DegreeOfPolymerisation = new List<SubstancePolymer.DegreeOfPolymerisationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DegreeOfPolymerisation.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.DegreeOfPolymerisation.Count == 0)
          {
            current.DegreeOfPolymerisation = null;
          }

          break;

        case "structuralRepresentation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.StructuralRepresentation = new List<SubstancePolymer.StructuralRepresentationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.StructuralRepresentation.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.StructuralRepresentation.Count == 0)
          {
            current.StructuralRepresentation = null;
          }

          break;

        // Complex: repeatUnit, Export: RepeatUnitComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstancePolymer#DegreeOfPolymerisation into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer.DegreeOfPolymerisationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstancePolymer#DegreeOfPolymerisation, Export: DegreeOfPolymerisationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Degree != null)
      {
        writer.WritePropertyName("degree");
        current.Degree.SerializeJson(writer, options);
      }

      if (current.Amount != null)
      {
        writer.WritePropertyName("amount");
        current.Amount.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer#DegreeOfPolymerisation
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer.DegreeOfPolymerisationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer#DegreeOfPolymerisation
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer.DegreeOfPolymerisationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "degree":
          current.Degree = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "amount":
          current.Amount = JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstanceAmount>(ref reader, options);

          break;

        // Complex: degreeOfPolymerisation, Export: DegreeOfPolymerisationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstancePolymer#StructuralRepresentation into JSON
    /// </summary>
    public static void SerializeJson(this SubstancePolymer.StructuralRepresentationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstancePolymer#StructuralRepresentation, Export: StructuralRepresentationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if ((current.RepresentationElement != null) && (current.RepresentationElement.Value != null))
      {
        writer.WriteString("representation",current.RepresentationElement.Value);
      }

      if (current.Attachment != null)
      {
        writer.WritePropertyName("attachment");
        current.Attachment.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstancePolymer#StructuralRepresentation
    /// </summary>
    public static void DeserializeJson(this SubstancePolymer.StructuralRepresentationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstancePolymer#StructuralRepresentation
    /// </summary>
    public static void DeserializeJsonProperty(this SubstancePolymer.StructuralRepresentationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.Type = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "representation":
          current.RepresentationElement = new FhirString(reader.GetString());

          break;

        case "attachment":
          current.Attachment = JsonSerializer.Deserialize<Hl7.Fhir.Model.Attachment>(ref reader, options);

          break;

        // Complex: structuralRepresentation, Export: StructuralRepresentationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubstancePolymerJsonConverter : JsonConverter<SubstancePolymer>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(SubstancePolymer).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, SubstancePolymer value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override SubstancePolymer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        SubstancePolymer target = new SubstancePolymer();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
