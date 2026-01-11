import React from "react";

type AppVersion = string;

interface FeatureVersionProps {
  versions: Partial<Record<AppVersion, React.ReactNode>>;
  fallback?: React.ReactNode;
}

export const FeatureVersion = ({ versions, fallback }: FeatureVersionProps) => {
  const currentVersion = process.env.EXPO_PUBLIC_FEATURE_VERSION || "v1";

  const componentToRender = versions[currentVersion];

  return <>{componentToRender ?? fallback ?? null}</>;
};
