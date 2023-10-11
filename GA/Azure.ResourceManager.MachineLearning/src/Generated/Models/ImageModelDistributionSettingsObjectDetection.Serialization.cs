// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageModelDistributionSettingsObjectDetection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BoxDetectionsPerImage))
            {
                if (BoxDetectionsPerImage != null)
                {
                    writer.WritePropertyName("boxDetectionsPerImage"u8);
                    writer.WriteStringValue(BoxDetectionsPerImage);
                }
                else
                {
                    writer.WriteNull("boxDetectionsPerImage");
                }
            }
            if (Optional.IsDefined(BoxScoreThreshold))
            {
                if (BoxScoreThreshold != null)
                {
                    writer.WritePropertyName("boxScoreThreshold"u8);
                    writer.WriteStringValue(BoxScoreThreshold);
                }
                else
                {
                    writer.WriteNull("boxScoreThreshold");
                }
            }
            if (Optional.IsDefined(ImageSize))
            {
                if (ImageSize != null)
                {
                    writer.WritePropertyName("imageSize"u8);
                    writer.WriteStringValue(ImageSize);
                }
                else
                {
                    writer.WriteNull("imageSize");
                }
            }
            if (Optional.IsDefined(MaxSize))
            {
                if (MaxSize != null)
                {
                    writer.WritePropertyName("maxSize"u8);
                    writer.WriteStringValue(MaxSize);
                }
                else
                {
                    writer.WriteNull("maxSize");
                }
            }
            if (Optional.IsDefined(MinSize))
            {
                if (MinSize != null)
                {
                    writer.WritePropertyName("minSize"u8);
                    writer.WriteStringValue(MinSize);
                }
                else
                {
                    writer.WriteNull("minSize");
                }
            }
            if (Optional.IsDefined(ModelSize))
            {
                if (ModelSize != null)
                {
                    writer.WritePropertyName("modelSize"u8);
                    writer.WriteStringValue(ModelSize);
                }
                else
                {
                    writer.WriteNull("modelSize");
                }
            }
            if (Optional.IsDefined(MultiScale))
            {
                if (MultiScale != null)
                {
                    writer.WritePropertyName("multiScale"u8);
                    writer.WriteStringValue(MultiScale);
                }
                else
                {
                    writer.WriteNull("multiScale");
                }
            }
            if (Optional.IsDefined(NmsIouThreshold))
            {
                if (NmsIouThreshold != null)
                {
                    writer.WritePropertyName("nmsIouThreshold"u8);
                    writer.WriteStringValue(NmsIouThreshold);
                }
                else
                {
                    writer.WriteNull("nmsIouThreshold");
                }
            }
            if (Optional.IsDefined(TileGridSize))
            {
                if (TileGridSize != null)
                {
                    writer.WritePropertyName("tileGridSize"u8);
                    writer.WriteStringValue(TileGridSize);
                }
                else
                {
                    writer.WriteNull("tileGridSize");
                }
            }
            if (Optional.IsDefined(TileOverlapRatio))
            {
                if (TileOverlapRatio != null)
                {
                    writer.WritePropertyName("tileOverlapRatio"u8);
                    writer.WriteStringValue(TileOverlapRatio);
                }
                else
                {
                    writer.WriteNull("tileOverlapRatio");
                }
            }
            if (Optional.IsDefined(TilePredictionsNmsThreshold))
            {
                if (TilePredictionsNmsThreshold != null)
                {
                    writer.WritePropertyName("tilePredictionsNmsThreshold"u8);
                    writer.WriteStringValue(TilePredictionsNmsThreshold);
                }
                else
                {
                    writer.WriteNull("tilePredictionsNmsThreshold");
                }
            }
            if (Optional.IsDefined(ValidationIouThreshold))
            {
                if (ValidationIouThreshold != null)
                {
                    writer.WritePropertyName("validationIouThreshold"u8);
                    writer.WriteStringValue(ValidationIouThreshold);
                }
                else
                {
                    writer.WriteNull("validationIouThreshold");
                }
            }
            if (Optional.IsDefined(ValidationMetricType))
            {
                if (ValidationMetricType != null)
                {
                    writer.WritePropertyName("validationMetricType"u8);
                    writer.WriteStringValue(ValidationMetricType);
                }
                else
                {
                    writer.WriteNull("validationMetricType");
                }
            }
            if (Optional.IsDefined(AmsGradient))
            {
                if (AmsGradient != null)
                {
                    writer.WritePropertyName("amsGradient"u8);
                    writer.WriteStringValue(AmsGradient);
                }
                else
                {
                    writer.WriteNull("amsGradient");
                }
            }
            if (Optional.IsDefined(Augmentations))
            {
                if (Augmentations != null)
                {
                    writer.WritePropertyName("augmentations"u8);
                    writer.WriteStringValue(Augmentations);
                }
                else
                {
                    writer.WriteNull("augmentations");
                }
            }
            if (Optional.IsDefined(Beta1))
            {
                if (Beta1 != null)
                {
                    writer.WritePropertyName("beta1"u8);
                    writer.WriteStringValue(Beta1);
                }
                else
                {
                    writer.WriteNull("beta1");
                }
            }
            if (Optional.IsDefined(Beta2))
            {
                if (Beta2 != null)
                {
                    writer.WritePropertyName("beta2"u8);
                    writer.WriteStringValue(Beta2);
                }
                else
                {
                    writer.WriteNull("beta2");
                }
            }
            if (Optional.IsDefined(Distributed))
            {
                if (Distributed != null)
                {
                    writer.WritePropertyName("distributed"u8);
                    writer.WriteStringValue(Distributed);
                }
                else
                {
                    writer.WriteNull("distributed");
                }
            }
            if (Optional.IsDefined(EarlyStopping))
            {
                if (EarlyStopping != null)
                {
                    writer.WritePropertyName("earlyStopping"u8);
                    writer.WriteStringValue(EarlyStopping);
                }
                else
                {
                    writer.WriteNull("earlyStopping");
                }
            }
            if (Optional.IsDefined(EarlyStoppingDelay))
            {
                if (EarlyStoppingDelay != null)
                {
                    writer.WritePropertyName("earlyStoppingDelay"u8);
                    writer.WriteStringValue(EarlyStoppingDelay);
                }
                else
                {
                    writer.WriteNull("earlyStoppingDelay");
                }
            }
            if (Optional.IsDefined(EarlyStoppingPatience))
            {
                if (EarlyStoppingPatience != null)
                {
                    writer.WritePropertyName("earlyStoppingPatience"u8);
                    writer.WriteStringValue(EarlyStoppingPatience);
                }
                else
                {
                    writer.WriteNull("earlyStoppingPatience");
                }
            }
            if (Optional.IsDefined(EnableOnnxNormalization))
            {
                if (EnableOnnxNormalization != null)
                {
                    writer.WritePropertyName("enableOnnxNormalization"u8);
                    writer.WriteStringValue(EnableOnnxNormalization);
                }
                else
                {
                    writer.WriteNull("enableOnnxNormalization");
                }
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                if (EvaluationFrequency != null)
                {
                    writer.WritePropertyName("evaluationFrequency"u8);
                    writer.WriteStringValue(EvaluationFrequency);
                }
                else
                {
                    writer.WriteNull("evaluationFrequency");
                }
            }
            if (Optional.IsDefined(GradientAccumulationStep))
            {
                if (GradientAccumulationStep != null)
                {
                    writer.WritePropertyName("gradientAccumulationStep"u8);
                    writer.WriteStringValue(GradientAccumulationStep);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationStep");
                }
            }
            if (Optional.IsDefined(LayersToFreeze))
            {
                if (LayersToFreeze != null)
                {
                    writer.WritePropertyName("layersToFreeze"u8);
                    writer.WriteStringValue(LayersToFreeze);
                }
                else
                {
                    writer.WriteNull("layersToFreeze");
                }
            }
            if (Optional.IsDefined(LearningRate))
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteStringValue(LearningRate);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (Optional.IsDefined(LearningRateScheduler))
            {
                if (LearningRateScheduler != null)
                {
                    writer.WritePropertyName("learningRateScheduler"u8);
                    writer.WriteStringValue(LearningRateScheduler);
                }
                else
                {
                    writer.WriteNull("learningRateScheduler");
                }
            }
            if (Optional.IsDefined(ModelName))
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Optional.IsDefined(Momentum))
            {
                if (Momentum != null)
                {
                    writer.WritePropertyName("momentum"u8);
                    writer.WriteStringValue(Momentum);
                }
                else
                {
                    writer.WriteNull("momentum");
                }
            }
            if (Optional.IsDefined(Nesterov))
            {
                if (Nesterov != null)
                {
                    writer.WritePropertyName("nesterov"u8);
                    writer.WriteStringValue(Nesterov);
                }
                else
                {
                    writer.WriteNull("nesterov");
                }
            }
            if (Optional.IsDefined(NumberOfEpochs))
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs"u8);
                    writer.WriteStringValue(NumberOfEpochs);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (Optional.IsDefined(NumberOfWorkers))
            {
                if (NumberOfWorkers != null)
                {
                    writer.WritePropertyName("numberOfWorkers"u8);
                    writer.WriteStringValue(NumberOfWorkers);
                }
                else
                {
                    writer.WriteNull("numberOfWorkers");
                }
            }
            if (Optional.IsDefined(Optimizer))
            {
                if (Optimizer != null)
                {
                    writer.WritePropertyName("optimizer"u8);
                    writer.WriteStringValue(Optimizer);
                }
                else
                {
                    writer.WriteNull("optimizer");
                }
            }
            if (Optional.IsDefined(RandomSeed))
            {
                if (RandomSeed != null)
                {
                    writer.WritePropertyName("randomSeed"u8);
                    writer.WriteStringValue(RandomSeed);
                }
                else
                {
                    writer.WriteNull("randomSeed");
                }
            }
            if (Optional.IsDefined(StepLRGamma))
            {
                if (StepLRGamma != null)
                {
                    writer.WritePropertyName("stepLRGamma"u8);
                    writer.WriteStringValue(StepLRGamma);
                }
                else
                {
                    writer.WriteNull("stepLRGamma");
                }
            }
            if (Optional.IsDefined(StepLRStepSize))
            {
                if (StepLRStepSize != null)
                {
                    writer.WritePropertyName("stepLRStepSize"u8);
                    writer.WriteStringValue(StepLRStepSize);
                }
                else
                {
                    writer.WriteNull("stepLRStepSize");
                }
            }
            if (Optional.IsDefined(TrainingBatchSize))
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize"u8);
                    writer.WriteStringValue(TrainingBatchSize);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (Optional.IsDefined(ValidationBatchSize))
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize"u8);
                    writer.WriteStringValue(ValidationBatchSize);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRCycles))
            {
                if (WarmupCosineLRCycles != null)
                {
                    writer.WritePropertyName("warmupCosineLRCycles"u8);
                    writer.WriteStringValue(WarmupCosineLRCycles);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRCycles");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRWarmupEpochs))
            {
                if (WarmupCosineLRWarmupEpochs != null)
                {
                    writer.WritePropertyName("warmupCosineLRWarmupEpochs"u8);
                    writer.WriteStringValue(WarmupCosineLRWarmupEpochs);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRWarmupEpochs");
                }
            }
            if (Optional.IsDefined(WeightDecay))
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay"u8);
                    writer.WriteStringValue(WeightDecay);
                }
                else
                {
                    writer.WriteNull("weightDecay");
                }
            }
            writer.WriteEndObject();
        }

        internal static ImageModelDistributionSettingsObjectDetection DeserializeImageModelDistributionSettingsObjectDetection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> boxDetectionsPerImage = default;
            Optional<string> boxScoreThreshold = default;
            Optional<string> imageSize = default;
            Optional<string> maxSize = default;
            Optional<string> minSize = default;
            Optional<string> modelSize = default;
            Optional<string> multiScale = default;
            Optional<string> nmsIouThreshold = default;
            Optional<string> tileGridSize = default;
            Optional<string> tileOverlapRatio = default;
            Optional<string> tilePredictionsNmsThreshold = default;
            Optional<string> validationIouThreshold = default;
            Optional<string> validationMetricType = default;
            Optional<string> amsGradient = default;
            Optional<string> augmentations = default;
            Optional<string> beta1 = default;
            Optional<string> beta2 = default;
            Optional<string> distributed = default;
            Optional<string> earlyStopping = default;
            Optional<string> earlyStoppingDelay = default;
            Optional<string> earlyStoppingPatience = default;
            Optional<string> enableOnnxNormalization = default;
            Optional<string> evaluationFrequency = default;
            Optional<string> gradientAccumulationStep = default;
            Optional<string> layersToFreeze = default;
            Optional<string> learningRate = default;
            Optional<string> learningRateScheduler = default;
            Optional<string> modelName = default;
            Optional<string> momentum = default;
            Optional<string> nesterov = default;
            Optional<string> numberOfEpochs = default;
            Optional<string> numberOfWorkers = default;
            Optional<string> optimizer = default;
            Optional<string> randomSeed = default;
            Optional<string> stepLRGamma = default;
            Optional<string> stepLRStepSize = default;
            Optional<string> trainingBatchSize = default;
            Optional<string> validationBatchSize = default;
            Optional<string> warmupCosineLRCycles = default;
            Optional<string> warmupCosineLRWarmupEpochs = default;
            Optional<string> weightDecay = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boxDetectionsPerImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        boxDetectionsPerImage = null;
                        continue;
                    }
                    boxDetectionsPerImage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boxScoreThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        boxScoreThreshold = null;
                        continue;
                    }
                    boxScoreThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        imageSize = null;
                        continue;
                    }
                    imageSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxSize = null;
                        continue;
                    }
                    maxSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        minSize = null;
                        continue;
                    }
                    minSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelSize = null;
                        continue;
                    }
                    modelSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiScale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        multiScale = null;
                        continue;
                    }
                    multiScale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nmsIouThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nmsIouThreshold = null;
                        continue;
                    }
                    nmsIouThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tileGridSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tileGridSize = null;
                        continue;
                    }
                    tileGridSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tileOverlapRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tileOverlapRatio = null;
                        continue;
                    }
                    tileOverlapRatio = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tilePredictionsNmsThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tilePredictionsNmsThreshold = null;
                        continue;
                    }
                    tilePredictionsNmsThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationIouThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationIouThreshold = null;
                        continue;
                    }
                    validationIouThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationMetricType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationMetricType = null;
                        continue;
                    }
                    validationMetricType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amsGradient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amsGradient = null;
                        continue;
                    }
                    amsGradient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("augmentations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        augmentations = null;
                        continue;
                    }
                    augmentations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta1 = null;
                        continue;
                    }
                    beta1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta2 = null;
                        continue;
                    }
                    beta2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distributed = null;
                        continue;
                    }
                    distributed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStopping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStopping = null;
                        continue;
                    }
                    earlyStopping = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStoppingDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingDelay = null;
                        continue;
                    }
                    earlyStoppingDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStoppingPatience"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingPatience = null;
                        continue;
                    }
                    earlyStoppingPatience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableOnnxNormalization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableOnnxNormalization = null;
                        continue;
                    }
                    enableOnnxNormalization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evaluationFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evaluationFrequency = null;
                        continue;
                    }
                    evaluationFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gradientAccumulationStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationStep = null;
                        continue;
                    }
                    gradientAccumulationStep = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layersToFreeze"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        layersToFreeze = null;
                        continue;
                    }
                    layersToFreeze = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRateScheduler = null;
                        continue;
                    }
                    learningRateScheduler = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("momentum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        momentum = null;
                        continue;
                    }
                    momentum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nesterov"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nesterov = null;
                        continue;
                    }
                    nesterov = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfWorkers = null;
                        continue;
                    }
                    numberOfWorkers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("optimizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        optimizer = null;
                        continue;
                    }
                    optimizer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("randomSeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        randomSeed = null;
                        continue;
                    }
                    randomSeed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepLRGamma"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRGamma = null;
                        continue;
                    }
                    stepLRGamma = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepLRStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRStepSize = null;
                        continue;
                    }
                    stepLRStepSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRCycles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRCycles = null;
                        continue;
                    }
                    warmupCosineLRCycles = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRWarmupEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRWarmupEpochs = null;
                        continue;
                    }
                    warmupCosineLRWarmupEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weightDecay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetString();
                    continue;
                }
            }
            return new ImageModelDistributionSettingsObjectDetection(amsGradient.Value, augmentations.Value, beta1.Value, beta2.Value, distributed.Value, earlyStopping.Value, earlyStoppingDelay.Value, earlyStoppingPatience.Value, enableOnnxNormalization.Value, evaluationFrequency.Value, gradientAccumulationStep.Value, layersToFreeze.Value, learningRate.Value, learningRateScheduler.Value, modelName.Value, momentum.Value, nesterov.Value, numberOfEpochs.Value, numberOfWorkers.Value, optimizer.Value, randomSeed.Value, stepLRGamma.Value, stepLRStepSize.Value, trainingBatchSize.Value, validationBatchSize.Value, warmupCosineLRCycles.Value, warmupCosineLRWarmupEpochs.Value, weightDecay.Value, boxDetectionsPerImage.Value, boxScoreThreshold.Value, imageSize.Value, maxSize.Value, minSize.Value, modelSize.Value, multiScale.Value, nmsIouThreshold.Value, tileGridSize.Value, tileOverlapRatio.Value, tilePredictionsNmsThreshold.Value, validationIouThreshold.Value, validationMetricType.Value);
        }
    }
}