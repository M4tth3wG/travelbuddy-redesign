declare global {
  namespace NodeJS {
    interface ProcessEnv {
      EXPO_PUBLIC_FEATURE_VERSION: "v1" | "v2" | "v3";
    }
  }
}

export {};
