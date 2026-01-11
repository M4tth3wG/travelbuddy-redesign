import React from "react";
import AddingTripPointView1 from "@/views/AddingTripPointViews/AddingTripPointView";
import AddingTripPointView2 from "@/views/AddingTripPointViews/AddingTripPointView2";
import AddingTripPointView3 from "@/views/AddingTripPointViews/AddingTripPointView3";
import { FeatureVersion } from "@/components/FeatureVersion";

export default function CreatingTripPointView() {
  return (
    <FeatureVersion
      versions={{
        v1: <AddingTripPointView1 />,
        v2: <AddingTripPointView2 />,
        v3: <AddingTripPointView3 />,
      }}
      fallback={<AddingTripPointView1 />}
    />
  );
}
