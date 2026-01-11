import React from "react";
import EditingTripPointView1 from "@/views/EditingTripPointViews/EditingTripPointView";
import EditingTripPointView2 from "@/views/EditingTripPointViews/EditingTripPointView2";
import EditingTripPointView3 from "@/views/EditingTripPointViews/EditingTripPointView3";
import { FeatureVersion } from "@/components/FeatureVersion";

const EditingTripPoint = () => {
  return (
    <FeatureVersion
      versions={{
        v1: <EditingTripPointView1 />,
        v2: <EditingTripPointView2 />,
        v3: <EditingTripPointView3 />,
      }}
      fallback={<EditingTripPointView1 />}
    />
  );
};

export default EditingTripPoint;
