# Download the helper library from https://www.twilio.com/docs/ruby/install
require 'rubygems'
require 'twilio-ruby'

# Your Account Sid and Auth Token from twilio.com/console
# DANGER! This is insecure. See http://twil.io/secure
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'
@client = Twilio::REST::Client.new(account_sid, auth_token)

address = @client.addresses.create(
                              customer_name: 'customer_name',
                              street: 'street',
                              city: 'city',
                              region: 'region',
                              postal_code: 'postal_code',
                              iso_country: 'US'
                            )

puts address.sid
