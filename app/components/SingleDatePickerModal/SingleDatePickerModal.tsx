import React from "react";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import { FeatureVersion } from "@/components/FeatureVersion";
import SingleDatePickerModal1 from "./SingleDatePickerModal1";
import SingleDatePickerModal2 from "./SingleDatePickerModal2";
import SingleDatePickerModal3 from "./SingleDatePickerModal3";

interface SingleDatePickerModalProps {
  visible: boolean;
  startDate: string;
  endDate: string;
  onDismiss: () => void;
  onConfirm: ({ date }: { date: CalendarDate }) => void;
}

const SingleDatePickerModal = (props: SingleDatePickerModalProps) => {
  return (
    <FeatureVersion
      versions={{
        v1: <SingleDatePickerModal1 {...props} />,
        v2: <SingleDatePickerModal2 {...props} />,
        v3: <SingleDatePickerModal3 {...props} />,
      }}
      fallback={<SingleDatePickerModal1 {...props} />}
    />
  );
};

export default SingleDatePickerModal;
