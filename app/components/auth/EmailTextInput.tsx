import { TextInput, useTheme } from "react-native-paper";
import {
  StyleProp,
  TextStyle,
  StyleSheet,
  NativeSyntheticEvent,
  TextInputFocusEventData,
} from "react-native";

export function EmailTextInput({
  style,
  value,
  onChangeText,
  error,
  onBlur,
}: {
  style: StyleProp<TextStyle>;
  value: string | undefined;
  onChangeText: (((text: string) => void) & Function) | undefined;
  onBlur?: (e: NativeSyntheticEvent<TextInputFocusEventData>) => void;
  error: boolean | undefined;
}) {
  const theme = useTheme();
  const innerStyle = makeStyles(theme);

  return (
    <TextInput
      style={style}
      value={value}
      onChangeText={onChangeText}
      onBlur={onBlur}
      error={error}
      mode="outlined"
      placeholder="Email"
      keyboardType="email-address"
      inputMode="email"
      left={<TextInput.Icon style={innerStyle.icon} icon="at" />}
    />
  );
}

// TODO: Change later any to theme type
const makeStyles = (theme: any) =>
  StyleSheet.create({
    icon: {
      backgroundColor: theme.colors.surface,
    },
  });
