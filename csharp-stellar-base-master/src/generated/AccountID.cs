          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Stellar.Generated
{


// === xdr source ============================================================
//  typedef PublicKey AccountID;
//  ===========================================================================
public class AccountID {
  public PublicKey InnerValue { get; set; } = default(PublicKey);
            
  public AccountID() { }
  public AccountID(PublicKey AccountID)
  {
    InnerValue = AccountID;
  }
  public static void Encode(IByteWriter stream, AccountID  encodedAccountID) {
  PublicKey.Encode(stream, encodedAccountID.InnerValue);
  }
  public static AccountID Decode(IByteReader stream) {
    AccountID decodedAccountID = new AccountID();
  decodedAccountID.InnerValue = PublicKey.Decode(stream);
    return decodedAccountID;
  }
}
}
