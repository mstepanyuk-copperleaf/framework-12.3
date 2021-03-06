// GENERATED CODE - DO NOT EDIT !!!
using System.Collections.Generic;
using CL.FormulaHelper;
using CL.FormulaHelper.Attributes;
using CL.FormulaHelper.DTOs;
using System.Runtime.Serialization;

namespace MeasureFormulas.Generated_Formula_Base_Classes
{
    [FormulaBase]
    public abstract class GenARMProbabilityBase : FormulaLikelihoodBase
    {
        [DataContract]
        public class TimeInvariantInputDTO
        {
            public TimeInvariantInputDTO(
                CL.FormulaHelper.DTOs.XYCurveDTO p_AssetConditionDecayCurve,
                CL.FormulaHelper.DTOs.XYCurveDTO p_ConditionToFailureCurve,
                System.Double?[] p_GenARM_Condition_ConsqUnitOutput,
                System.Double? p_SystemCondition_32_Score_32_Best,
                System.Double? p_SystemCondition_32_Score_32_Worst,
                System.Int32? p_SystemNumber_32_of_32_baseline_32_PDF_32_subsamples)
            {
                AssetConditionDecayCurve = p_AssetConditionDecayCurve;
                ConditionToFailureCurve = p_ConditionToFailureCurve;
                GenARM_Condition_ConsqUnitOutput = p_GenARM_Condition_ConsqUnitOutput;
                SystemCondition_32_Score_32_Best = p_SystemCondition_32_Score_32_Best;
                SystemCondition_32_Score_32_Worst = p_SystemCondition_32_Score_32_Worst;
                SystemNumber_32_of_32_baseline_32_PDF_32_subsamples = p_SystemNumber_32_of_32_baseline_32_PDF_32_subsamples;
            }
            
            [CoreFieldInput(FormulaCoreFieldInputType.AssetConditionDecayCurve)]
            [DataMember]
            public CL.FormulaHelper.DTOs.XYCurveDTO AssetConditionDecayCurve  { get; private set; }
            
            [CoreFieldInput(FormulaCoreFieldInputType.ConditionToFailureCurve)]
            [DataMember]
            public CL.FormulaHelper.DTOs.XYCurveDTO ConditionToFailureCurve  { get; private set; }
            
            [MeasureInput("GenARM", "Condition", MeasureOutputType.ConsqUnitOutput, false)]
            [DataMember]
            public System.Double?[] GenARM_Condition_ConsqUnitOutput  { get; private set; }
            
            [CustomFieldInput("Condition Score Best", FormulaInputAssociatedEntity.System)]
            [DataMember]
            public System.Double? SystemCondition_32_Score_32_Best  { get; private set; }
            
            [CustomFieldInput("Condition Score Worst", FormulaInputAssociatedEntity.System)]
            [DataMember]
            public System.Double? SystemCondition_32_Score_32_Worst  { get; private set; }
            
            [CustomFieldInput("Number of baseline PDF subsamples", FormulaInputAssociatedEntity.System)]
            [DataMember]
            public System.Int32? SystemNumber_32_of_32_baseline_32_PDF_32_subsamples  { get; private set; }
        }
        
        [DataContract]
        public class TimeVariantInputDTO : ITimeVariantInputDTO
        {
            public TimeVariantInputDTO(
                CL.FormulaHelper.DTOs.TimePeriodDTO p_TimePeriod)
            {
                TimePeriod = p_TimePeriod;
            }
            
            [CoreFieldInput(FormulaCoreFieldInputType.TimePeriod)]
            [DataMember]
            public CL.FormulaHelper.DTOs.TimePeriodDTO TimePeriod  { get; private set; }
        }
        
        public abstract double?[] GetLikelihoodValues(int startFiscalYear, int months,
            TimeInvariantInputDTO timeInvariantData, IReadOnlyList<TimeVariantInputDTO> timeVariantData);
            
        
        ///
        /// Class to enable formula debugging
        ///
        [DataContract]
        public class FormulaParams : IFormulaParams
        {
            public FormulaParams(CL.FormulaHelper.MeasureOutputType measureOutputType,
                string measureName,
                long alternativeId,
                string formulaImplClassName,
                bool isProbabilityFormula,
                int fiscalYearEndMonth,
                int startFiscalYear,
                int months,
                TimeInvariantInputDTO timeInvariantData,
                IReadOnlyList<TimeVariantInputDTO> timeVariantData,
                double?[] unitOutput,
                object formulaOutput,
                string exceptionMessage)
            {
                MeasureOutputType = measureOutputType;
                MeasureName = measureName;
                AlternativeId = alternativeId;
                FormulaImplClassName = formulaImplClassName;
                IsProbabilityFormula = isProbabilityFormula;
                FiscalYearEndMonth = fiscalYearEndMonth;
                StartFiscalYear = startFiscalYear;
                Months = months;
                TimeInvariantData = timeInvariantData;
                TimeVariantData = timeVariantData;
                UnitOutput = unitOutput;
                FormulaOutput = formulaOutput;
                ExceptionMessage = exceptionMessage;
            }
            [DataMember(Order = 0)]
            public CL.FormulaHelper.MeasureOutputType MeasureOutputType { get; set; }
            [DataMember(Order = 1)]
            public string MeasureName { get; set; }
            [DataMember(Order = 2)]
            public long AlternativeId { get; set; }
            [DataMember(Order = 3)]
            public string FormulaImplClassName { get; set; }
            [DataMember(Order = 4)]
            public bool IsProbabilityFormula { get; set; }
            [DataMember(Order = 5)]
            public int FiscalYearEndMonth { get; set; }
            [DataMember(Order = 6)]
            public int StartFiscalYear { get; set; }
            [DataMember(Order = 7)]
            public int Months { get; set; }
            [DataMember(Order = 8)]
            public TimeInvariantInputDTO TimeInvariantData { get; set; }
            [DataMember(Order = 9)]
            public IReadOnlyList<TimeVariantInputDTO> TimeVariantData { get; set; }
            [DataMember(Order = 10)]
            public double?[] UnitOutput { get; set; }
            [DataMember(Order = 11)]
            public object FormulaOutput { get; set; }
            [DataMember(Order = 12)]
            public string ExceptionMessage { get; set; }
        }
    }
}
// GENERATED CODE - DO NOT EDIT !!!
