import { TextInput, useTheme } from "react-native-paper";
import {
  StyleProp,
  TextStyle,
  Platform,
  GestureResponderEvent,
  StyleSheet,
  NativeSyntheticEvent,
  TextInputFocusEventData,
} from "react-native";
import { useState } from "react";

export function PasswordTextInput({
  style,
  value,
  onChangeText,
  onBlur,
  error,
  placeholder,
}: {
  style: StyleProp<TextStyle>;
  value: string | undefined;
  onChangeText: (((text: string) => void) & Function) | undefined;
  onBlur?: (e: NativeSyntheticEvent<TextInputFocusEventData>) => void;
  error?: boolean | undefined;
  placeholder?: string;
}) {
  const [hidePassword, setHidePassword] = useState(true);
  const theme = useTheme();
  const innerStyle = makeStyles(theme);

  const switchPasswordVisibility = (e: GestureResponderEvent) => {
    setHidePassword((prev) => !prev);
  };

  return (
    <TextInput
      style={style}
      value={value}
      onChangeText={onChangeText}
      onBlur={onBlur}
      error={error || undefined}
      mode="outlined"
      placeholder={placeholder ?? "Hasło"}
      left={<TextInput.Icon icon="lock-outline" />}
      right={
        <TextInput.Icon
          icon={hidePassword ? "eye" : "eye-off"}
          style={innerStyle.icon}
          forceTextInputFocus={false}
          onPress={switchPasswordVisibility}
        />
      }
      secureTextEntry={Platform.OS !== "ios" && hidePassword}
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
